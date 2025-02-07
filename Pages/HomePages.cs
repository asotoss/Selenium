﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTest.Base;

namespace SeleniumTest.Pages
{
    public class HomePages : DriverInit
    {

        IWebDriver driver;


        public By menu = By.XPath("//*[@id='mount_0_0']/div/div[1]/div[1]/div[2]/div[4]/div[1]/span/div/div[1]/i");

        public By CloseSesion = By.XPath("//span[contains(text(),'Cerrar sesión')]");

        public HomePages(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void ClickMenu()
        {
            IWebElement ele = this.driver.FindElement(menu);
            ele.Click();
        }

        public void ClickCloseSesion()
        {
            IWebElement ele = this.driver.FindElement(CloseSesion);
            ele.Click();
        }

    }
}
