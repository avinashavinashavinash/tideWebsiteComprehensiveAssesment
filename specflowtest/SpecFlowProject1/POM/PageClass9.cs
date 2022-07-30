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
    public class PageClass9
    {
        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnWhatsNew()
        {

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();



            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/latest-news']")).Click();

        }

        public void ClickOnTheTideHygienicClean()
        {

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("")).Click();


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='article-preview-link' and @href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-spring-meadow']")).Click();

        }
        public void ClickOnStickerClose()
        {


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

        }

        public void VerifyTheTextFromAmericasTrusted()
        {
            Thread.Sleep(3000);
            string text1 = BaseClass.driver.FindElement(By.XPath("//div[@class='description']")).Text;

            Thread.Sleep(3000);

            if (text1.Contains("From America's #1 Trusted Detergent Brand*"))
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
