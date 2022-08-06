using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;


namespace TideProjectNunit.POM
    {
    [TestFixture]
    public class SearchBox1 : ReportsGenerationClass
        {
        [Test]
        public void SearchBoxOtpion1()
            {
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Url = "https://tide.com/en-us";

           // driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.XPath ("//input[@type='search']")).SendKeys ("Clean Breeze Powder");

            driver.FindElement (By.XPath ("//button[@type='submit']")).Click ();

            driver.FindElement (By.XPath ("//div[@class='ps-widget ps-59923902a81961211a377174 event_buy_now event_buy_now_choose_product ps-enabled'][1]")).Click ();

            string text1 = driver.FindElement (By.XPath ("//h1[@class='ps-product-name']")).Text;

            if(text1.Contains ("Tide Clean Breeze Powder"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }

      ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            ExcelSheet.excelRead ();

            //logNet.log.Info();
            Assert.Pass ();

            }
        }
    }
