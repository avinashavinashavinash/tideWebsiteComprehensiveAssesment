
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class OurCommitment7
    {

        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }


        public void ClickOnNavigateOurCommitment()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/our-commitment']")).Click();

        }

        public void ClickOnOurAmbition()
        {

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("")).Click();


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='button-link event_button_click secondary' and @href='/en-us/our-commitment/a-load-of-good']")).Click();

        }
        public void ClickOnStickerClose()
        {


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

        }

        public void VerifyTheTextManufacturing()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            string text1 = BaseClass.driver.FindElement(By.CssSelector("div[class='richtext-container ']>h3")).Text;

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            if (text1.Contains("1. Manufacturing"))
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("not present");
            }
        }


        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }



    }
}
