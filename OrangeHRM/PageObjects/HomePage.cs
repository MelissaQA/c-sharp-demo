using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.BaseClass;
using OrangeHRM.PageObjects.AdminModule;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObjects
{
    public class HomePage : BasePage
    {
        public IWebElement LnkWelcome2;
        public HomePage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //[FindsBy(How = How.Id, Using = "welcome")]
        //public IWebElement LnkWelcome { get; set; }
        [FindsBy(How = How.Id, Using = "menu_admin_viewAdminModule")]
        public IWebElement AdminTab { get; set; }

        public String GetLnkWelcome()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement welcomeLink = wait.Until(driver => this.driver.FindElement(By.Id("welcome")));
            //this.LnkWelcome = this.driver.FindElement(By.Id("welcome"));
                        
            string text = welcomeLink.Text;
            return text;
        }

        public UserManagementPage ClickOnAdminUserManagementPage() 
        {
            //AdminTab.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement adminTab = wait.Until(driver => this.driver.FindElement(By.Id("menu_admin_viewAdminModule")));
            adminTab.Click();

            return new UserManagementPage(driver);
        }
    }
}
