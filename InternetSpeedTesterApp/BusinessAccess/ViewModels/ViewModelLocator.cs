using GalaSoft.MvvmLight;
using InternetSpeedTesterApp.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSpeedTesterApp.BusinessAccess.ViewModels
{
    public class ViewModelLocator
    {
        private StandardKernel _kernel;
        public ViewModelBase Main { get; private set; }

        public ViewModelLocator()
        {
            if (ViewModelBase.IsInDesignModeStatic)
                _kernel = new StandardKernel(new DesignTimeModule());
            else
                _kernel = new StandardKernel(new RunTimeModule());

            //About = _kernel.Get<AboutViewModel>();
            Main = _kernel.Get<MainViewModel>();
        }

        //public MainViewModel MainContext
        //{
        //    get { return _kernel.Get<MainViewModel>(); }
        //}

    }
}
