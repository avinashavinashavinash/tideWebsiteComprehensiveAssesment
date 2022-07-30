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
    public class PageClass7
    {

        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }


        public void ClickOnNavigateOurCommitment()
        {

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/our-commitment']")).Click();

        }

        public void ClickOnOurAmbition()
        {

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("")).Click();


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='button-link event_button_click secondary' and @href='/en-us/our-commitment/a-load-of-good']")).Click();

        }
        public void ClickOnStickerClose()
        {


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

        }

        public void VerifyTheTextManufacturing()
        {
            Thread.Sleep(3000);
            string text1 = BaseClass.driver.FindElement(By.CssSelector("div[class='richtext-container ']>h3")).Text;

            Thread.Sleep(3000);

            if (text1.Contains("1. Manufacturing"))
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
