
using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class Live
    {

        public void LoadWebsite()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

       
            }

        public void LiveChat()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            //Thread.Sleep(6000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();


            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
        }

        public void Verifytheclosedchat()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            //Thread.Sleep(3000);
            string text1 = BaseClass.driver.FindElement(By.XPath("//button[@class='disabled-button button-link / chat-button event_button_click']")).Text;

            //Thread.Sleep(3000);

            if (text1.Contains("Chat closed"))
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

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
            }


















        }
}
