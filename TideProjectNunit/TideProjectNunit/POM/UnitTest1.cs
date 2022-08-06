//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using SeleniumNUnitExtentReport.Config;
//using TideProjectNunit.Utitlites;


//namespace TideProjectNunit.POM
//    {


//    [TestFixture]
//    public class Tests : ReportsGenerationClass
//        {
        

//        //[Test]
//        //public void SearchBox1()
//        //    {
//        //    driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//        //    driver.Url = "https://tide.com/en-us";
            
//        //    driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//        //    driver.FindElement (By.XPath ("//input[@type='search']")).SendKeys ("Clean Breeze Powder");

//        //    driver.FindElement (By.XPath ("//button[@type='submit']")).Click ();
           
//        //    driver.FindElement (By.XPath ("//div[@class='ps-widget ps-59923902a81961211a377174 event_buy_now event_buy_now_choose_product ps-enabled'][1]")).Click ();
           
//        //    string text1 = driver.FindElement (By.XPath ("//h1[@class='ps-product-name']")).Text;

//        //    if(text1.Contains ("Tide Clean Breeze Powder"))
//        //        {
//        //        Console.WriteLine ("present");
//        //        }
//        //    else
//        //        {
//        //        Console.WriteLine ("not present");
//        //        }

//        //    ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

//        //    ExcelSheet.excelRead ();

//        //    //logNet.log.Info();
//        //    Assert.Pass ();

//        //    }


//        //[Test]
//        //public void LiveChatOption2()
//        //    {

//        //    driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//        //    driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          
//        //    driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//        //    driver.FindElement (By.XPath ("//a[@href='/en-us/live-chat']")).Click ();
 
//        //    string text1 = driver.FindElement (By.XPath ("//button[@class='disabled-button button-link / chat-button event_button_click']")).Text;

//        //    if(text1.Contains ("Chat closed"))
//        //        {
//        //        Console.WriteLine ("present");
//        //        }
//        //    else
//        //        {
//        //        Console.WriteLine ("not present");
//        //        }

//        //           ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

//        //    Assert.Pass ();

//        //    }


//        //[Test]
//        //public void Test3()
//        //    {
//        //    driver.Manage ().Timeouts ().ImplicitWait = TimeS2an.FromSeconds (10);
//        //    
//        //    driver.Navigate ().GoToUrl ("https://tide.com/en-us");
//        //  
//        //    //Thread.Sleep (2000);
//        //    driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();
//        //   
//        //    driver.FindElement (By.XPath ("//a[@href='/en-us/contact-us']")).Click ();

//        //    //Thread.Sleep (2000);
//        //    driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

//        //    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
//        //    System.Threading.Thread.Sleep (5000);
//        //    js.ExecuteScript ("window.scrollBy(0,500)");

//        //    Thread.Sleep (12000);
//        //    driver.FindElement (By.XPath ("//div[@class='a058000000Gy5gvAABNav  hoverInc']")).Click ();

//        //    Thread.Sleep (4000);
//        //    driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:j_id90:j_id91:j_id125']")).Click ();

//        //    Thread.Sleep (4000);
//        //    driver.FindElement (By.XPath ("//select[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idReasonForWriting']")).Click ();

//        //    driver.FindElement (By.XPath ("//option[@value='Ask a question']")).Click ();
//        //    driver.FindElement (By.XPath ("//textarea[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idEmailDescription']")).SendKeys ("jksndjcn jkds cj jsdcjk sdjcdksc");
//        //    driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idFirstName1']")).SendKeys ("avgbhgh");
//        //    driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idLastName1']")).SendKeys ("sdcsddc");
//        //    driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idEmail']")).SendKeys ("abcm@gmail.com");

//        //    driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idSubmitBtn']")).Click ();
//        //    ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
//        //    Assert.Pass ();

//        //    }











//        //[Test]
//        //public void LanguageChangeOption3()
//        //    {
//        //    driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//        //    driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          
//        //    driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//        //    driver.FindElement (By.XPath (".//button[text()='US - English']")).Click ();

//        //    driver.FindElement (By.XPath ("//a[@href='https://tide.com/es-us']")).Click ();

//        //    driver.FindElement (By.XPath (".//button[text()='US - Español']")).Click ();

//        //    driver.FindElement (By.XPath ("//a[@href='/']")).Click ();

//        //    ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
//        //    Assert.Pass ();

//        //    }


//        [Test]
//        public void Register4()
//            {
//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);
           
//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          
//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//            driver.FindElement (By.XPath ("//span[@class='login-register']")).Click ();
//            // driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();

//            driver.FindElement (By.XPath ("//a[@class='event_internal_link']")).Click ();

//            driver.Navigate ().GoToUrl ("https://www.pggoodeveryday.com/login/");
          
//            driver.FindElement (By.XPath ("//input[@id='login-email']")).SendKeys ("avinashchandavar99@gmail.com");

//            driver.FindElement (By.XPath ("//input[@id='login-password']")).SendKeys ("Avinash@12345");


//            //driver.FindElement (By.XPath ("//input[@class='active  submitBtn btn btn-primaryReceipt']")).Click ();
           
//            //string text1 = driver.FindElement (By.XPath ("//h1[@class='page-title relative text-center text-white pt-25 lg:pt-30 xl:min-h-84 lg:leading-headerline font-montserratSemiBold font-semibold text-30 lg:text-50 leading-wider ']")).Text;
//            //if(text1.Contains ("Coupons"))
//            //    {
//            //    Console.WriteLine ("present");
//            //    }
//            //else
//            //    {
//            //    Console.WriteLine ("not present");
//            //    }
            
//            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

//            Assert.Pass ();

  

//            }





//        [Test]
//        public void ToVerifyShopProducts5()
//            {

//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            
//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");

//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();
   
//            //driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();

//            driver.FindElement (By.CssSelector ("a[href='/en-us/shop']")).Click ();

//            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

//            driver.FindElement (By.XPath ("(//span[text()='Find Retailers'])[1]")).Click ();
           
//            string text1 = driver.FindElement (By.XPath ("//h1[text()='Tide Clean Breeze Powder']")).Text;
//            if(text1.Contains ("Tide Clean Breeze Powder"))
//                {
//                Console.WriteLine ("present");
//                }
//            else
//                {
//                Console.WriteLine ("not present");
//                }

//            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

//            Assert.Pass ();

  
//            }




//        [Test]
//        public void ToVerifyOurCommitment6()
//            {
//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          
//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();
     
//            //driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();

//            driver.FindElement (By.CssSelector ("a[href='/en-us/our-commitment']")).Click ();

//            driver.FindElement (By.XPath ("//a[@class='button-link event_button_click secondary' and @href='/en-us/our-commitment/a-load-of-good']")).Click ();


//            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

//            string text1 = driver.FindElement (By.CssSelector ("div[class='richtext-container ']>h3")).Text;
//            if(text1.Contains ("1. Manufacturing"))
//                {
//                Console.WriteLine ("present");
//                }
//            else
//                {
//                Console.WriteLine ("not present");
//                }



//            Assert.Pass ();

  
//            }



//        [Test]
//        public void VerifyHowToWashClothes7()
//            {
//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

            
//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          

//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//            driver.FindElement (By.CssSelector ("a[href='/en-us/how-to-wash-clothes']")).Click ();

//            driver.FindElement (By.XPath ("//a[@class='button-link event_button_click secondary' and @href='/en-us/how-to-wash-clothes/washing-machine-101']")).Click ();

//            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();
   
//            string text8 = driver.FindElement (By.XPath ("//a[@class='article-preview-title' and @href='/en-us/how-to-wash-clothes/washing-machine-101/how-to-use-an-he-washer']")).Text;
//                if(text8.Contains ("How to Use an HE Washer"))
//                {
//                Console.WriteLine ("present");
//                }
//            else
//                {
//                Console.WriteLine ("not present");
//                }

//            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

//            Assert.Pass ();

  
//            }




//        [Test]
//        public void VerifyWhatsNew8()
//            {

//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          
//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//            driver.FindElement (By.CssSelector ("a[href='/en-us/latest-news']")).Click ();

//            driver.FindElement (By.XPath ("//a[@class='article-preview-link' and @href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-spring-meadow']")).Click ();

//            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();
           
//            string text1 = driver.FindElement (By.XPath ("//div[@class='description']")).Text;
//            if(text1.Contains ("From America's #1 Trusted Detergent Brand*"))
//                {
//                Console.WriteLine ("present");
//                }
//            else
//                {
//                Console.WriteLine ("not present");
//                }

//            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
//            Assert.Pass ();

  
//            }



//        [Test]
//        public void VerifyCouponsAndRewards9()
//            {

//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
           
//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//            driver.FindElement (By.CssSelector ("a[href='/en-us/coupons-and-rewards']")).Click ();

//            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

//            driver.FindElement (By.XPath ("//a[@class='event_internal_link' and @href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click ();

//            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

//            Assert.Pass ();
            
//            }



//        [Test]

//        public void VerifyToVerifyPG10()
//            {

//            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (20);

//            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
          
//            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

//            driver.FindElement (By.CssSelector ("a[href='https://us.pg.com']")).Click ();

//            driver.FindElement (By.XPath ("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).Click ();

//            driver.FindElement (By.XPath ("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).SendKeys ("Press Kits");

//            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
//            Thread.Sleep (5000);
//            js.ExecuteScript ("window.scrollBy(0,500)");

//            driver.FindElement (By.XPath ("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']")).Click ();

//            //driver.FindElement(By.XPath("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']/h2")).SendKeys(Keys.Return);

            
//            string text1 = driver.FindElement (By.XPath ("//span[text()='CES 2020 Press Kit']")).Text;

//            if(text1.Contains ("CES 2020 Press Kit"))
//                {
//                Console.WriteLine ("present");
//                }
//            else
//                {
//                Console.WriteLine ("not present");
//                }


//            Assert.Pass ();

//            }


//        }





//    }