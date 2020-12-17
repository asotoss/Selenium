using OpenQA.Selenium;
using SeleniumTest.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumTest.Pages
{
   public class LoginPages : DriverInit
    {
        IWebDriver driver;

        public By email = By.Id("email");

        public By pasword = By.Name("pass");

        public By loginButton = By.Id("u_0_b");

        public By Loginform = By.CssSelector("form[class='_featuredLogin__formContainer']");

        public LoginPages(IWebDriver driver)
        {
            this.driver = driver;
        }



        public void EnterEmail(string text)
        {
            IWebElement ele = driver.FindElement(email);
            ele.SendKeys(text);
        }

        public void EnterPassword(string text)
        {
            IWebElement ele = driver.FindElement(pasword);
            ele.SendKeys(text);
        }

        public void ClickButton()
        {
            IWebElement ele = driver.FindElement(loginButton);
            ele.Click();
        }


        public bool IsLoginFormPresent()
        {
            bool isFOund = false;
            try
            {
                IWebElement element = driver.FindElement(Loginform);
                if (element.Displayed && element.Enabled)
                {
                    isFOund = true;
                }
                return isFOund;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


    }
}
