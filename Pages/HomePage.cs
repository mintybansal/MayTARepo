﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTa.Pages
{
    class HomePage
    {
        //Function to navigate to TM page
        public void navigateToTM(IWebDriver driver)
        {
            //Navigate to Time and Material page
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
    }
}
