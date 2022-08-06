
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class Language4
    {

        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }


        public void Lang()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

           
        }

        public void langclick()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath(".//button[text()='US - English']")).Click();

        }


        public void spanish()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();

        }
        public void english()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath(".//button[text()='US - Español']")).Click();

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@href='/']")).Click();

        }

        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }

    }
}

