using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;

namespace TideProjectNunit.POM
    {
    [TestFixture]
    public class ShopProduct5 : ReportsGenerationClass
        {
        [Test]
        public void ToVerifyShopProducts5()
            {

            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);


            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

            //driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            //driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();

            driver.FindElement (By.CssSelector ("a[href='/en-us/shop']")).Click ();

            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            driver.FindElement (By.XPath ("(//span[text()='Find Retailers'])[1]")).Click ();

            string text1 = driver.FindElement (By.XPath ("//h1[text()='Tide Clean Breeze Powder']")).Text;
            if(text1.Contains ("Tide Clean Breeze Powder"))
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
