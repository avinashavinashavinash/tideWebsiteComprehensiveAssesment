using System;
using System.Collections.Generic;

using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class PandG
    {

        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnPandG()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (30);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();



            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (0);
            BaseClass.driver.FindElement(By.CssSelector("a[href='https://us.pg.com']")).Click();

        }

        public void SearchboxMiddle()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).Click();


            
          

        }



        public void ThenEnterNew()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            BaseClass.driver.FindElement(By.XPath("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).SendKeys("Press Kits");

            //JavascriptExecutor j = (JavascriptExecutor)driver;
            //j.executeScript("window.scrollBy(0,500)");



            IJavaScriptExecutor js = BaseClass.driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,500)");

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']")).Click();

            //BaseClass.driver.FindElement(By.XPath("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']/h2")).SendKeys(Keys.Return);
        }





        public void VerifyTheTextPressKitsProcterGambleNews()
        {
            {
                BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
                string text1 = BaseClass.driver.FindElement(By.XPath("//span[text()='CES 2020 Press Kit']")).Text;

              

                if (text1.Contains("CES 2020 Press Kit"))
                {
                    Console.WriteLine("present");
                }
                else
                {
                    Console.WriteLine("not present");
                }
            }

        }

        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }
    }
}