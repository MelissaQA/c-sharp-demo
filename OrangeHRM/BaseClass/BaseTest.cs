using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}
