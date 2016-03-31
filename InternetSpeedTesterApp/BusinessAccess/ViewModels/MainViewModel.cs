using GalaSoft.MvvmLight;
using InternetSpeedTesterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSpeedTesterApp.BusinessAccess.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string GetCurrrentValue { get; set; }
        public MainViewModel(IInternetSpeedService internetSpeedService)
        {
            GetCurrrentValue = internetSpeedService.GetCurrrentValue;
        }

    }
}
