using System;
using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;
using TideWebsiteTesting.Hooks;
namespace TideWebsiteTesting.POM
    {
    public class CouponReward
    {
        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }

        public void ClickOnCouponsAndRewards()
        {

            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();



            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.CssSelector("a[href='/en-us/coupons-and-rewards']")).Click();

        }
        public void ClickOnStickerClose()
        {


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click();

        }
        public void ClickOnTheSaveNow()
        {

            //Thread.Sleep(4000);
            //BaseClass.driver.FindElement(By.XPath("")).Click();


            BaseClass.driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
            BaseClass.driver.FindElement(By.XPath("//a[@class='event_internal_link' and @href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click();

        }
        

     


        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }

    }
}
