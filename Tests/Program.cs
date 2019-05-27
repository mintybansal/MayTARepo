using MayTa.Helpers;
using MayTa.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MayTa
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonDriver.driver = new ChromeDriver();

            // Steps to login
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(CommonDriver.driver);

            //Steps to navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(CommonDriver.driver);

            //Steps to create a TM
            TMPage tmObj = new TMPage();
            tmObj.addTM(CommonDriver.driver);

            
        }
    }
}
