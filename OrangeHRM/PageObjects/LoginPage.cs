using System;
using System.Collections.Generic;
using System.Text;
using OrangeHRM.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using NUnit.Framework;

namespace OrangeHRM.PageObjects
{
    public class LoginPage : BasePage
    {

        //private IWebDriver driver;

        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "txtUsername")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement BtnLogin { get; set; }


        public HomePage SignIn() 
        {
            TxtUserName.SendKeys("admin");
            TxtPassword.SendKeys("admin123");
            BtnLogin.Click();

            return new HomePage(driver);    
        }
    }
}
