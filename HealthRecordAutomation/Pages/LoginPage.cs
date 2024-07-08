using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.HealthRecordAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
        }
       
        public void EnterPassword(string password)
        {
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
        }
        
        public string GetAppDesc()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
        }

        public string GetLoginPageTitle()
        {
            return driver.Title;
        }
    }
}
