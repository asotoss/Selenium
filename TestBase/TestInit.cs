using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Base;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.TestBase
{
   public class TestInit : DriverInit
    {
        [SetUp]
        public void Initialize()
        {
            ChromeOptions chromeoptions = new ChromeOptions();
            chromeoptions.AddArgument("no-sandbox");
            driver = new ChromeDriver(chromeoptions);
            //navigate to URL  
            //driver.Navigate().GoToUrl("https://www.facebook.com/");
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
            driver.Quit();
        }

        public LoginPages Login
        {
            get { return new LoginPages(driver); }
        }

        public HomePages HomePagesgin
        {
            get { return new HomePages(driver); }
        }

    }
}
