using SeleniumTest.Base;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.TestBase
{
   public class TestInit : Driver
    {

        public LoginPages Login
        {
            get { return new LoginPages(); }
        }

        public HomePages HomePagesgin
        {
            get { return new HomePages(); }
        }

    }
}
