using MayTa.Helpers;
using MayTa.Pages;
using NUnit.Framework;
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
    [TestFixture]
    class Program
    {
        [SetUp]
        public void Login()
        {
            CommonDriver.driver = new ChromeDriver();

            // Steps to login
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(CommonDriver.driver);

            //Steps to navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(CommonDriver.driver);
        }

        [Test]
        public void AddTMTest()
        {
            //Steps to create a TM
            TMPage tmObj = new TMPage();
            tmObj.addTM(CommonDriver.driver);
        }

        [Test]
        public void EditTMTest()
        {
            //Steps to edit an existing TM
            TMPage tmObj = new TMPage();
            tmObj.editTM(CommonDriver.driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            //Steps to delete an existing TM
            TMPage tmObj = new TMPage();
            tmObj.deleteTM(CommonDriver.driver);
        }

        [TearDown]
        public void FlushTest()
        {
            //Close driver
            CommonDriver.driver.Close();
        }


        static void Main(string[] args)
        {
   

        }
    }
}
