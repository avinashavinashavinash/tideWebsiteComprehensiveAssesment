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
using OpenQA.Selenium.Interactions;

namespace Tide11.POM
{
    public class PageClass5
    {



        public void LoadWebsite()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();

        }



        public void ClickOnRegsiter()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//span[@class='login-register']")).Click();
           // BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
        }


        public void ClickOnSignUpNow()
        {
           
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='event_internal_link']")).Click();

        }


        public void ClickOnLogin()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/login/");
                BaseClass.driver.Manage().Window.Maximize();
        }

        public void EnterInfo()


        {
          

            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys("avinashchandavar99@gmail.com");

            BaseClass.driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys("Avinash@12345");


            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//input[@class='active  submitBtn btn btn-primaryReceipt']")).Click();


        }

        //public void VerifyThelogintext()
        //{
        //    //Thread.Sleep(2000);
        //    //BaseClass.driver.FindElement(By.XPath("")).Click();


        //    Thread.Sleep(3000);
        //    string text1 = BaseClass.driver.FindElement(By.XPath("//h1[@class='page-title relative text-center text-white pt-25 lg:pt-30 xl:min-h-84 lg:leading-headerline font-montserratSemiBold font-semibold text-30 lg:text-50 leading-wider ']")).Text;

        //    Thread.Sleep(3000);

        //    if (text1.Contains("Coupons"))
        //    {
        //        Console.WriteLine("present");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not present");
        //    }
        //}

        public void ScreenShot()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
        }

    }
}
