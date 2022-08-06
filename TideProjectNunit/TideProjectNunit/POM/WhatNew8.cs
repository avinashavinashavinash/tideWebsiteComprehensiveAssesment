using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;
namespace TideProjectNunit.POM
    {

    [TestFixture]
    public class WhatNew8 : ReportsGenerationClass
        {
     
        [Test]
        public void VerifyWhatsNew8()
            {

            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

            //driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.CssSelector ("a[href='/en-us/latest-news']")).Click ();

            driver.FindElement (By.XPath ("//a[@class='article-preview-link' and @href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-spring-meadow']")).Click ();

            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            string text1 = driver.FindElement (By.XPath ("//div[@class='description']")).Text;
            if(text1.Contains ("From America's #1 Trusted Detergent Brand*"))
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
