using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support;
using System.Threading;

using Tide11.Utitlites;

using Tide11.POM;

namespace Tide11.POM
{
    public class PageClass1
    {
       

        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
          
        }


        public void Searchbox()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//input[@type='search']")).SendKeys("Clean Breeze Powder");


        }

        public void TypeCleanBreezePowder()
        {

            

            Thread.Sleep(2000);

            BaseClass.driver.FindElement(By.XPath("//button[@type='submit']")).Click();

        }

        public void ClickOnFirstLink()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//div[@class='ps-widget ps-59923902a81961211a377174 event_buy_now event_buy_now_choose_product ps-enabled'][1]")).Click();
        }

        public void VerifyTheText()
        {
            Thread.Sleep(3000);
            string text1 = BaseClass.driver.FindElement(By.XPath("//h1[@class='ps-product-name']")).Text;

            Thread.Sleep(3000);

            if (text1.Contains("Tide Clean Breeze Powder"))
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("not present");
            }
        }

        public void ScreenShot()
        {
            ExcelSheet.excelRead ();

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }


    }
}

