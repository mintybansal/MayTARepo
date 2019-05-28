using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MayTa.Pages
{
    class TMPage
    {
        //Function to create TM
        public void addTM(IWebDriver driver)
        {
            //Create a new time and material

            //Click on create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Enter a code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("testCode");

            //Enter value for description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testDescription");

            //Enter price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("123");

            //Click save button
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            Thread.Sleep(1000);

            //Verify the creation of time and material record

            //Navigate to the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]"));

            if (actualCode.Text == "testCode")
            {
                Console.WriteLine("Test Passed, material created successully");
            }
            else
            {
                Console.WriteLine("Test Failed!");
            }
        }

        //Function to edit TM
        public void editTM(IWebDriver driver)
        {
            //code to edit an existing TM
        }

        //Function to delete TM
        public void deleteTM(IWebDriver driver)
        {
            //code to delete an existing TM
        }
    }
}
