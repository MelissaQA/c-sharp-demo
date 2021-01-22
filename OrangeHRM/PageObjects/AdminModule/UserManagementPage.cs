using OpenQA.Selenium;
using OrangeHRM.BaseClass;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObjects.AdminModule
{
    public class UserManagementPage : BasePage
    {
        public UserManagementPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "searchSystemUser_userName")]
        private IWebElement TxtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "searchBtn")]
        private IWebElement BtnSearch { get; set; }


        public Boolean searchUserByUsername(string username) 
        {
            TxtUsername.SendKeys(username);
            BtnSearch.Click();
            return false;
        }

    }
}
