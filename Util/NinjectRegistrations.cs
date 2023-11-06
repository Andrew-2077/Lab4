using BLL.Services;
using Interfaces.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ISongsService>().To<SongsService>();
            Bind<IReportsService>().To<ReportsService>();
            Bind<ISingersService>().To<SingersService>();
        }
    }
}
