using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support;
using System.Threading;

using Tide11.POM;


namespace Tide11.POM
{
    public class PageClass6
    {


        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnNavigateShopProducts()
        {

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/shop']")).Click();

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();


        }

        public void ClickOnFabricCare()
        {

           Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("(//span[text()='Find Retailers'])[1]")).Click();

        }

        //public void ClickOnAntibacterial()
        //{


        //    Thread.Sleep(2000);
        //    BaseClass.driver.FindElement(By.XPath("")).Click();

        //}

        public void VerifyTheText()
        {
            Thread.Sleep(3000);
            string text1 = BaseClass.driver.FindElement(By.XPath("//h1[text()='Tide Clean Breeze Powder']")).Text;

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
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }


    }
}
