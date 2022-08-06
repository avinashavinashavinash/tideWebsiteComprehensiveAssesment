
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class Whatsnew9
    {
        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnWhatsNew()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();



            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/latest-news']")).Click();

        }

        public void ClickOnTheTideHygienicClean()
        {

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("")).Click();

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='article-preview-link' and @href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-spring-meadow']")).Click();

        }
        public void ClickOnStickerClose()
        {


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

        }

        public void VerifyTheTextFromAmericasTrusted()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            string text1 = BaseClass.driver.FindElement(By.XPath("//div[@class='description']")).Text;

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            if (text1.Contains("From America's #1 Trusted Detergent Brand*"))
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
