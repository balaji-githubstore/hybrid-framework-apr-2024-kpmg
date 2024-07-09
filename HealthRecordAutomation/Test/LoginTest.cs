using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPMG.HealthRecordAutomation.Base;
using KPMG.HealthRecordAutomation.Utilities;
using KPMG.HealthRecordAutomation.Pages;
using HealthRecordAutomation.Pages;

namespace KPMG.HealthRecordAutomation.Test
{
    public class LoginTest : AutomationWrapper
    {

        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginDataExcel))]
        //[TestCase("admin","pass","OpenEMR")]
        //[TestCase("physician", "physician", "OpenEMR")]
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            //move the GetMainPageTitle() to MainPage class
            MainPage mainPage = new MainPage(driver);
            string actualTitle = mainPage.GetMainPageTitle();

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData))]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            //Assert - Invalid username or password 
            //string actualError = loginPage.GetInvalidErrorMessage();

            Assert.That(loginPage.GetInvalidErrorMessage(), Is.EqualTo(expectedError));
        }

    }
}
