using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSpeedTesterApp.BusinessAccess
{
    public class MockInternetSpeedService : IInternetSpeedService
    {
         public MockInternetSpeedService()
        {
            getCurrrentValue = "Design mode";
        }

        string getCurrrentValue;
        public string GetCurrrentValue
        {
            get
            {
                return getCurrrentValue;
            }

            set
            {
                getCurrrentValue = value;
            }
        }
    }
}
