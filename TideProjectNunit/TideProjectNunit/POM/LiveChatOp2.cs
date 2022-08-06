using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;

namespace TideProjectNunit.POM
    {

    [TestFixture]
    public class LiveChatOp2 : ReportsGenerationClass
        {

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger (System.Reflection.MethodBase.GetCurrentMethod ().DeclaringType);

        [Test]
        public void LiveChatOption2()
            {

            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

           // driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.XPath ("//a[@href='/en-us/live-chat']")).Click ();

            string text1 = driver.FindElement (By.XPath ("//button[@class='disabled-button button-link / chat-button event_button_click']")).Text;

            if(text1.Contains ("Chat closed"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }

                ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");



            log.Info ("dsdcsddcs");
            Assert.Pass ();

            }
        }
    }
