
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
using TideWebsiteTesting.Utitlites;

namespace TideWebsiteTesting.POM
    {
    public class SearchBox1 : BaseClass
    { 
        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
          
        }


        public void Searchbox()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//input[@type='search']")).SendKeys("Clean Breeze Powder");
        }

        public void TypeCleanBreezePowder()
        {



            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            BaseClass.driver.FindElement(By.XPath("//button[@type='submit']")).Click();

        }

        public void ClickOnFirstLink()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//div[@class='ps-widget ps-59923902a81961211a377174 event_buy_now event_buy_now_choose_product ps-enabled'][1]")).Click();
        }

        public void VerifyTheText()
        {
            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            string text1 = BaseClass.driver.FindElement(By.XPath("//h1[@class='ps-product-name']")).Text;

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
            ExcelSheet.excelRead ();

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }


    }
}

