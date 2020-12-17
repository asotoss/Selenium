using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using SeleniumTest.TestBase;


namespace SeleniumTest 
{

    
   public class Class1 : TestInit
    {



        [Test]

        public void NewMethod()
        {
            
            

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Thread.Sleep(3000);
            Login.EnterEmail("red_eyes_adrian@hotmail.com");
            Thread.Sleep(3000);
            Login.EnterPassword(new Values().pws);
            Thread.Sleep(3000);
            Login.ClickButton();
            Thread.Sleep(3000);
            HomePagesgin.ClickMenu();
            Thread.Sleep(3000);
            HomePagesgin.ClickCloseSesion();
            Thread.Sleep(3000);

        }

        [Test]
        public void Test2()
        { 
        
        
        }



        //public void ExecuteTest()
        //{

        //    string xpath = "//*[@id='mount_0_0']/div/div[1]/div[1]/div[2]/div[4]/div[1]/span/div/div[1]/i";

        //    string xpat2 = "//span[contains(text(),'Cerrar sesión')]";

        //    //identify the username text box  
        //    IWebElement ele = driver.FindElement(By.Id("email"));
        //    //enter the username value  
        //    ele.SendKeys("red_eyes_adrian@hotmail.com");
        //    Thread.Sleep(2000);
        //    Console.Write("username value is entered");
        //    //identify the password text box  
        //    IWebElement ele1 = driver.FindElement(By.Name("pass"));
        //    //enter the password value  
        //    ele1.SendKeys("soto2608");
        //    Console.Write("password is entered");
        //    //click on the Login button  
        //    IWebElement ele2 = driver.FindElement(By.Id("u_0_b"));
        //    ele2.Click();
        //    Thread.Sleep(3000);
        //    Console.Write("login button is clicked");

        //    //IWebElement ele3 = driver.FindElement(By.CssSelector("div i[class*='hu5pjgll op6gxeva sp_j-o8QPZPfDc_1_5x sx_a370d0']"));

        //    IWebElement ele3 = driver.FindElement(By.XPath(xpath));
        //    ele3.Click();

        //    Thread.Sleep(3000);


        //    IWebElement ele4 = driver.FindElement(By.XPath(xpat2));

        //    ele4.Click();

        //    Thread.Sleep(3000);


        //    Assert.IsTrue(IsElementPresent(By.CssSelector("form[class='_featuredLogin__formContainer']")),"No se encuentra");
        //}

      


      


    }
}
