using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utilites;

namespace TideProjectNunit.POM
    {


    [TestFixture]
    public class LanguageChangeOp3 : ReportsGenerationClass
        {
        [Test]
        public void LanguageChangeOption3()
            {
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

            //driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.XPath (".//button[text()='US - English']")).Click ();

            driver.FindElement (By.XPath ("//a[@href='https://tide.com/es-us']")).Click ();

            driver.FindElement (By.XPath (".//button[text()='US - Español']")).Click ();

            driver.FindElement (By.XPath ("//a[@href='/']")).Click ();

            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            logNet.log.Info ("asdasd");
            
            Assert.Pass ();



            }

        }
    }
