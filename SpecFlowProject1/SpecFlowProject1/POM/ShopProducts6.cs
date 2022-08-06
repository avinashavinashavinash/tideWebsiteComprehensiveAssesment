
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class ShopProducts6
    {


        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnNavigateShopProducts()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            //Thread.Sleep(3000);
            //BaseClass.driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/shop']")).Click();

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();


        }

        public void ClickOnFabricCare()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("(//span[text()='Find Retailers'])[1]")).Click();

        }

        //public void ClickOnAntibacterial()
        //{


        //    Thread.Sleep(3000);
        //    BaseClass.driver.FindElement(By.XPath("")).Click();

        //}

        public void VerifyTheText()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            string text1 = BaseClass.driver.FindElement(By.XPath("//h1[text()='Tide Clean Breeze Powder']")).Text;

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            if (text1.Contains("Tide Clean Breeze Powder"))
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
