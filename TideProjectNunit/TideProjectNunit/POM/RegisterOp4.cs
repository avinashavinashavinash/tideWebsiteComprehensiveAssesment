using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;


namespace TideProjectNunit.POM
    {


    [TestFixture]
    internal class RegisterOp4 : ReportsGenerationClass
        {
        [Test]
        public void Register4()
            {
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

            //driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.XPath ("//span[@class='login-register']")).Click ();
            // driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();

            driver.FindElement (By.XPath ("//a[@class='event_internal_link']")).Click ();

            driver.Navigate ().GoToUrl ("https://www.pggoodeveryday.com/login/");

            driver.FindElement (By.XPath ("//input[@id='login-email']")).SendKeys ("avinashchandavar99@gmail.com");

            driver.FindElement (By.XPath ("//input[@id='login-password']")).SendKeys ("Avinash@12345");


            //driver.FindElement (By.XPath ("//input[@class='active  submitBtn btn btn-primaryReceipt']")).Click ();

            //string text1 = driver.FindElement (By.XPath ("//h1[@class='page-title relative text-center text-white pt-25 lg:pt-30 xl:min-h-84 lg:leading-headerline font-montserratSemiBold font-semibold text-30 lg:text-50 leading-wider ']")).Text;
            //if(text1.Contains ("Coupons"))
            //    {
            //    Console.WriteLine ("present");
            //    }
            //else
            //    {
            //    Console.WriteLine ("not present");
            //    }

            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            Assert.Pass ();



            }


        }
    }
