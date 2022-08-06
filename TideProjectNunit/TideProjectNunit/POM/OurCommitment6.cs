using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;


namespace TideProjectNunit.POM
    {

    [TestFixture]
    public class OurCommitment6 : ReportsGenerationClass
        {
        [Test]
        public void ToVerifyOurCommitment6()
            {
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

           // driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            //driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();

            driver.FindElement (By.CssSelector ("a[href='/en-us/our-commitment']")).Click ();

            driver.FindElement (By.XPath ("//a[@class='button-link event_button_click secondary' and @href='/en-us/our-commitment/a-load-of-good']")).Click ();


            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            string text1 = driver.FindElement (By.CssSelector ("div[class='richtext-container ']>h3")).Text;
            if(text1.Contains ("1. Manufacturing"))
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
