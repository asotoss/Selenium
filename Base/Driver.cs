using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Base
{
    public class Driver : DriverInit
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
            driver.Quit();
            driver.Close();

        }

    }
}
