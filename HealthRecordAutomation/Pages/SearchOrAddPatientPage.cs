using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Pages
{
    public class SearchOrAddPatientPage
    {
        private IWebDriver driver;

        public SearchOrAddPatientPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
