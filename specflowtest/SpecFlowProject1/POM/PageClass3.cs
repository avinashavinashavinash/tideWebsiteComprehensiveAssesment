using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support;
using System.Threading;

using Tide11.POM;

namespace Tide11.POM
{
    internal class PageClass3
    {
        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ContactUs()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/contact-us']")).Click();
        }


        public void Emailbutton()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

            IJavaScriptExecutor js = BaseClass.driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,500)");

            Thread.Sleep(12000);
            BaseClass.driver.FindElement(By.XPath("//div[@class='a058000000Gy5gvAABNav  hoverInc']")).Click();
        }

        public void AgreeAndContniue()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:j_id90:j_id91:j_id125']")).Click();

        }

        public void infomation()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//select[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idReasonForWriting']")).Click();

            BaseClass.driver.FindElement(By.XPath("//option[@value='Ask a question']")).Click();
            BaseClass.driver.FindElement(By.XPath("//textarea[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idEmailDescription']")).SendKeys("jksndjcn jkds cj jsdcjk sdjcdksc");
            BaseClass.driver.FindElement(By.XPath("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idFirstName1']")).SendKeys("avgbhgh");
            BaseClass.driver.FindElement(By.XPath("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idLastName1']")).SendKeys("sdcsddc");
            BaseClass.driver.FindElement(By.XPath("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idEmail']")).SendKeys("abcm@gmail.com");
        }

        public void Sumbitbutton()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idSubmitBtn']")).Click();
        }

        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }
    }
}
