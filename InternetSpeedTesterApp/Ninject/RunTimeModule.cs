using InternetSpeedTesterApp.BusinessAccess;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSpeedTesterApp.Ninject
{
    public class RunTimeModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IInternetSpeedService>().To<InternetSpeedService>();
        }
    }

}
