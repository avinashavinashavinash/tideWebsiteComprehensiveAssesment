
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class WashClothes8
    {



        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnNavigateHowToWashClothes()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();



            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/how-to-wash-clothes']")).Click();

        }

        public void ClickOnHowToUseWasher()
        {

            //Thread.Sleep(2000);
            //BaseClass.driver.FindElement(By.XPath("")).Click();


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='button-link event_button_click secondary' and @href='/en-us/how-to-wash-clothes/washing-machine-101']")).Click();

        }
        public void ClickOnStickerClose()
        {


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

        }

        public void VerifyTheTextWord()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            string text1 = BaseClass.driver.FindElement(By.XPath("//a[@class='article-preview-title' and @href='/en-us/how-to-wash-clothes/washing-machine-101/how-to-use-an-he-washer']")).Text;

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            if (text1.Contains("How to Use an HE Washer"))
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
