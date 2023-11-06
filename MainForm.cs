using Interfaces.DTO;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{

    public partial class MainForm : Form
    {
        ISongsService songsService;
        IReportsService reportsService;
        ISingersService singersService;

        List<LabelsDto> AllLabels;
        List<SingersDto> AllSingers;

        public MainForm(ISingersService singerservice, ISongsService songservice, IReportsService reportservice)
        {
            songsService = songservice;
            reportsService = reportservice;
            singersService = singerservice;
            InitializeComponent();
            loadData();
        }

        //загрузка данных в таблицы
        private void loadData()
        {
            AllLabels = singersService.GetLabels();
            loadSingers();
            loadSongs();
            // Заполнение комбобокса "Лейбл" для отчета1.
            comboBox1.DataSource = AllLabels;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

        }

        private void loadSingers()
        {
            AllSingers = singersService.GetAllSingers();
            // Отображаем данные
            bindingSourceSingers.DataSource = AllSingers;
            // Заполнение комбобокса "Лейбл" в таблице "Singers".
            FillLabelsCombobox();
        }

        private void loadSongs()
        {
            bindingSourceSongs.DataSource = songsService.GetAllSongs();
        }

        private void FillLabelsCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewSingers.Columns["label0"]).DataSource = AllLabels;
            ((DataGridViewComboBoxColumn)dataGridViewSingers.Columns["label0"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridViewSingers.Columns["label0"]).ValueMember = "Id";
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            dataGridViewReport1.DataSource = reportsService.ReportSingersOfLabels((int)comboBox1.SelectedValue);
        }

        private class SPResult
        {
            public string Song { get; set; }
            public string SingerName { get; set; }
            public DateTime Date { get; set; }
        }
        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetReport2_Click(object sender, EventArgs e)
        {
            dataGridViewReport2.DataSource = reportsService.ExecuteSP((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSingerForm f = new AddSingerForm();
            f.comboBox1.DataSource = AllLabels;
            f.comboBox1.DisplayMember = "Name";
            f.comboBox1.ValueMember = "Id";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            //if (result == DialogResult.Cancel)
            //{
            //    return;
            //}

            SingersDto singer = new SingersDto();
            singer.Label_ID = (int)f.comboBox1.SelectedValue;
            singer.Name_singer = f.textBox1.Text;
            singer.SubscriptionCost = f.numericUpDown1.Value;
            singer.Description = f.textBox2.Text;
            singersService.CreateSinger(singer);
            AllSingers = singersService.GetAllSingers();
            bindingSourceSingers.DataSource = AllSingers;
            MessageBox.Show("Новый исполнитель добавлен");
            //MessageBox.Show("Новый исполнитель добавлен");
        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewSingers);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewSingers[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                SingersDto si = AllSingers.Where(i => i.Id == id).FirstOrDefault();
                if (si != null)
                {
                    AddSingerForm f = new AddSingerForm();
                    f.comboBox1.DataSource = AllLabels;
                    f.comboBox1.DisplayMember = "Name";
                    f.comboBox1.ValueMember = "Id";
                    f.numericUpDown1.Value = si.SubscriptionCost;
                    f.comboBox1.SelectedValue = si.Label_ID;
                    f.textBox1.Text = si.Name_singer;
                    f.textBox2.Text = si.Description;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    si.SubscriptionCost = f.numericUpDown1.Value;
                    si.Name_singer = f.textBox1.Text;
                    si.Description = f.textBox2.Text;
                    si.Label_ID = (int)f.comboBox1.SelectedValue;
                    singersService.UpdateSinger(si);

                    MessageBox.Show("Объект обновлен");

                    AllSingers = singersService.GetAllSingers();
                    bindingSourceSingers.DataSource = AllSingers;
                }
            }
            else
            {
                MessageBox.Show("Ни один объект не выбран!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewSingers);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewSingers[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                singersService.DeleteSinger(id);
                bindingSourceSingers.DataSource = singersService.GetAllSingers();
            }
        }

        private void buttonMakeSong_Click(object sender, EventArgs e)
        {
            MakeSongForm f2 = new MakeSongForm(singersService, songsService);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                bindingSourceSongs.DataSource = songsService.GetAllSongs();
            }
        }

        private bool hasSelectedRow(DataGridView dataGridView)
        {
            return (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridViewSongs))
            {
                SongsDto song = (SongsDto)dataGridViewSongs.CurrentRow.DataBoundItem;
                MakeSongForm f2 = new MakeSongForm(singersService, songsService, song);
                if (f2.ShowDialog() == DialogResult.OK)
                    bindingSourceSongs.DataSource = songsService.GetAllSongs();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridViewSongs))
            {
                songsService.DeleteSong(((SongsDto)dataGridViewSongs.CurrentRow.DataBoundItem).Id);
                loadSongs();
            }
        }
    }
}
