using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHRM.BaseClass;
using OrangeHRM.PageObjects;
using OrangeHRM.PageObjects.AdminModule;

namespace OrangeHRM.TestScripts
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest() 
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = loginPage.SignIn();

            String expectedWelcomeLabel = homePage.GetLnkWelcome();
            Assert.IsTrue(expectedWelcomeLabel.Equals("Welcome Khawaza"));
            //Thread.Sleep(2000);
        }

        [Test]
        public void SearchUserAsAdmin() 
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = loginPage.SignIn();

            String expectedWelcomeLabel = homePage.GetLnkWelcome();
            Assert.IsTrue(expectedWelcomeLabel.Equals("Welcome Khawaza"));

            UserManagementPage userManagementPage = homePage.ClickOnAdminUserManagementPage();
            userManagementPage.searchUserByUsername("admin");
        }
    }
}
