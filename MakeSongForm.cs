using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces.DTO;
using Interfaces.Services;

namespace Lab4
{
    public partial class MakeSongForm : Form
    {
        ISingersService sb;
        ISongsService ssb;
        SongsDto selectedSong;
        public MakeSongForm(ISingersService sbOperations, ISongsService songsService, SongsDto s = null)
        {
            InitializeComponent();
            sb = sbOperations;
            ssb = songsService;
            selectedSong = s;

            ListBoxSingersOnSong.DataSource = sb.GetAllSingers();
            ListBoxSingersOnSong.DisplayMember = "Name_singer";
            ListBoxSingersOnSong.ValueMember = "Id";

            if (selectedSong != null)
            {
                for (int i = 0; i < ListBoxSingersOnSong.Items.Count; i++)
                {
                    SingersDto customizeItem = ListBoxSingersOnSong.Items[i] as SingersDto;
                    if (selectedSong.SongPerformersIds.Contains(customizeItem.Id))
                    {
                        ListBoxSingersOnSong.SetItemChecked(i, true);
                    }
                }
                tbSinger.Text = selectedSong.Singer;
                tbSong.Text = selectedSong.Song;
                tbDate.Text = selectedSong.Date.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListBoxSingersOnSong.CheckedItems.Count == 0)
            {
                MessageBox.Show("Не выбран ни один исполнитель");
                return;
            }
            List<int> items = new List<int>();
            foreach (var i in ListBoxSingersOnSong.CheckedItems)
                items.Add((i as SingersDto).Id);

            SongsDto songs;
            if (selectedSong == null)
            {
                songs = new SongsDto();
            }
            else
            {
                songs = selectedSong;
            }

            songs.Song = tbSong.Text;
            songs.Singer = tbSinger.Text;
            songs.Date = DateTime.Parse(tbDate.Text);
            songs.SongPerformersIds = items;

            var result = ssb.MakeSong(songs);
            if (result != null)
            {
                MessageBox.Show("Успешно!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
