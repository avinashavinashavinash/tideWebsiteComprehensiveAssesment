using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support;
using System.Threading;


namespace Tide11.POM
{
    public class PageClass2
    {
        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void LiveChat()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();


            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
        }

        public void Verifytheclosedchat()
        {
            Thread.Sleep(3000);
            string text1 = BaseClass.driver.FindElement(By.XPath("//button[@class='disabled-button button-link / chat-button event_button_click']")).Text;

            Thread.Sleep(3000);

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
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }



















    }
}
