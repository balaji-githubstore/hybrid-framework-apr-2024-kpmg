using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPMG.HealthRecordAutomation.Base;
using KPMG.HealthRecordAutomation.Utilities;

namespace KPMG.HealthRecordAutomation.Test
{
    public class LoginTest : AutomationWrapper
    {

        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
        //[TestCase("admin","pass","OpenEMR")]
        //[TestCase("physician", "physician", "OpenEMR")]
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData))]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            //Assert - Invalid username or password 
            string actualError = driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
            Assert.That(actualError, Is.EqualTo(expectedError));
        }

    }
}
