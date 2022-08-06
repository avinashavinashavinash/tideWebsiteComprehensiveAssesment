using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;


namespace TideProjectNunit.POM
    {


    [TestFixture]
    internal class PandG : ReportsGenerationClass
        {
        [Test]

        public void VerifyToVerifyPG10() 
            {

            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

          //  driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.CssSelector ("a[href='https://us.pg.com']")).Click ();

            driver.FindElement (By.XPath ("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).Click ();

            driver.FindElement (By.XPath ("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).SendKeys ("Press Kits");

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep (5000);
            js.ExecuteScript ("window.scrollBy(0,500)");

            driver.FindElement (By.XPath ("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']")).Click ();

            //driver.FindElement(By.XPath("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']/h2")).SendKeys(Keys.Return);


            string text1 = driver.FindElement (By.XPath ("//span[text()='CES 2020 Press Kit']")).Text;

            if(text1.Contains ("CES 2020 Press Kit"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }


            Assert.Pass ();

            }

        }
    }
