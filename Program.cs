using Lab4.Util;
using Interfaces.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // внедрение зависимостей
            var kernel = new StandardKernel(new NinjectRegistrations(), new ReposModule("SingerSongContext"));

            ISingersService singerServ = kernel.Get<ISingersService>();
            ISongsService songServ = kernel.Get<ISongsService>();
            IReportsService reportServ = kernel.Get<IReportsService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(singerServ, songServ, reportServ));
        }
    }
}
