using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;

namespace TideProjectNunit.POM
    {


    [TestFixture]
    internal class CouponsReward9 : ReportsGenerationClass
        {


        [Test]
        public void VerifyCouponsAndRewards9()
            {

            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

           // driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.CssSelector ("a[href='/en-us/coupons-and-rewards']")).Click ();

            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            driver.FindElement (By.XPath ("//a[@class='event_internal_link' and @href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click ();

            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            Assert.Pass ();

            }

        }
    }
