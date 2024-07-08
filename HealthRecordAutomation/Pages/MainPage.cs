using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Pages
{
    /// <summary>
    /// This class contain methods for all common element and all menu handlings.
    /// </summary>
    public class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetMainPageTitle()
        {
            return driver.Title;
        }
    }
}
