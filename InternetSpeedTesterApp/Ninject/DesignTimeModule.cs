using InternetSpeedTesterApp.BusinessAccess;
using InternetSpeedTesterApp.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSpeedTesterApp.Ninject
{
    public class DesignTimeModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IInternetSpeedService>().To<MockInternetSpeedService>();
        }
    }

}
