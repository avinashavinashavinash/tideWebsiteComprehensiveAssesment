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
    public class PageClass4
    {

        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }


        public void Lang()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

           
        }

        public void langclick()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath(".//button[text()='US - English']")).Click();

        }


        public void spanish()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();

        }
        public void english()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath(".//button[text()='US - Español']")).Click();

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@href='/']")).Click();

        }

        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }

    }
}

