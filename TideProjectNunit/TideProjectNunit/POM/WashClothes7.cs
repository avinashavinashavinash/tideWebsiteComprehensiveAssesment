using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;


namespace TideProjectNunit.POM
    {

    [TestFixture]
    public class WashClothes7 : ReportsGenerationClass
        {
        [Test]
        public void VerifyHowToWashClothes7()
            {
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);


            driver.Navigate ().GoToUrl ("https://tide.com/en-us");


            //driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.CssSelector ("a[href='/en-us/how-to-wash-clothes']")).Click ();

            driver.FindElement (By.XPath ("//a[@class='button-link event_button_click secondary' and @href='/en-us/how-to-wash-clothes/washing-machine-101']")).Click ();

            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            string text8 = driver.FindElement (By.XPath ("//a[@class='article-preview-title' and @href='/en-us/how-to-wash-clothes/washing-machine-101/how-to-use-an-he-washer']")).Text;
            if(text8.Contains ("How to Use an HE Washer"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }

           ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            Assert.Pass ();


            }

        }
    }
