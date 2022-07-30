using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitExtentReport.Config;
using TideProjectNunit.Utitlites;

namespace TideProjectNunit.POM
{


    [TestFixture]
    public class Tests : ReportsGenerationClass 
        {
        [SetUp]
        public void Setup()
            {
            //////IWebDriver driver = new FirefoxDriver ();
            }

        [Test]
        public void Searchbox()
            {
            

            //////IWebDriver driver = new FirefoxDriver ();


            driver.Url = "https://tide.com/en-us";
            ////driver.Manage ().Window.Maximize ();



            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//input[@type='search']")).SendKeys ("Clean Breeze Powder");




            Thread.Sleep (2000);

            driver.FindElement (By.XPath ("//button[@type='submit']")).Click ();



            Thread.Sleep (3000);
            driver.FindElement (By.XPath ("//div[@class='ps-widget ps-59923902a81961211a377174 event_buy_now event_buy_now_choose_product ps-enabled'][1]")).Click ();


            Thread.Sleep (3000);
            string text1 = driver.FindElement (By.XPath ("//h1[@class='ps-product-name']")).Text;

            Thread.Sleep (3000);

            if(text1.Contains ("Tide Clean Breeze Powder"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }


        ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            ExcelSheet.excelRead ();


            Assert.Pass ();

            //driver.Quit ();
            }


        [Test]
        public void Test2()
            {
            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            driver.FindElement (By.XPath ("//a[@href='/en-us/live-chat']")).Click ();

            Thread.Sleep (3000);
            string text1 = driver.FindElement (By.XPath ("//button[@class='disabled-button button-link / chat-button event_button_click']")).Text;

            Thread.Sleep (3000);

            if(text1.Contains ("Chat closed"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }

                   ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            Assert.Pass ();

            //driver.Quit ();
            }


        [Test]
        public void Test3()
            {



            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();



            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            Thread.Sleep (3000);
            driver.FindElement (By.XPath ("//a[@href='/en-us/contact-us']")).Click ();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep (5000);
            js.ExecuteScript ("window.scrollBy(0,500)");

            Thread.Sleep (12000);
            driver.FindElement (By.XPath ("//div[@class='a058000000Gy5gvAABNav  hoverInc']")).Click ();



            Thread.Sleep (4000);
            driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:j_id90:j_id91:j_id125']")).Click ();



            Thread.Sleep (4000);
            driver.FindElement (By.XPath ("//select[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idReasonForWriting']")).Click ();

            driver.FindElement (By.XPath ("//option[@value='Ask a question']")).Click ();
            driver.FindElement (By.XPath ("//textarea[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idEmailDescription']")).SendKeys ("jksndjcn jkds cj jsdcjk sdjcdksc");
            driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idFirstName1']")).SendKeys ("avgbhgh");
            driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idLastName1']")).SendKeys ("sdcsddc");
            driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idEmail']")).SendKeys ("abcm@gmail.com");




            driver.FindElement (By.XPath ("//input[@id='j_id0:j_id1:j_id2:idForm:j_id74:j_id75:idSubmitBtn']")).Click ();




            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");


            Assert.Pass ();

            //driver.Quit ();





            }











        [Test]
        public void Test4()
            {




            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();




            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();



            Thread.Sleep (2000);
            driver.FindElement (By.XPath (".//button[text()='US - English']")).Click ();




            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@href='https://tide.com/es-us']")).Click ();



            Thread.Sleep (2000);
            driver.FindElement (By.XPath (".//button[text()='US - Español']")).Click ();

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@href='/']")).Click ();

            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
            Assert.Pass ();

            //driver.Quit ();


            }

























        [Test]
        public void Test5()
            {

            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();



            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//span[@class='login-register']")).Click ();
            // driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();





            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='event_internal_link']")).Click ();





            driver.Navigate ().GoToUrl ("https://www.pggoodeveryday.com/login/");
            //driver.Manage ().Window.Maximize ();




            Thread.Sleep (4000);
            driver.FindElement (By.XPath ("//input[@id='login-email']")).SendKeys ("avinashchandavar99@gmail.com");

            driver.FindElement (By.XPath ("//input[@id='login-password']")).SendKeys ("Avinash@12345");


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//input[@class='active  submitBtn btn btn-primaryReceipt']")).Click ();




            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("")).Click();


            Thread.Sleep (3000);
            string text1 = driver.FindElement (By.XPath ("//h1[@class='page-title relative text-center text-white pt-25 lg:pt-30 xl:min-h-84 lg:leading-headerline font-montserratSemiBold font-semibold text-30 lg:text-50 leading-wider ']")).Text;

            Thread.Sleep (3000);

            if(text1.Contains ("Coupons"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }


        ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            Assert.Pass ();

            //driver.Quit ();

            }
        [Test]
        public void Test6()
            {

            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();




            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();


            Thread.Sleep (2000);
            driver.FindElement (By.CssSelector ("a[href='/en-us/shop']")).Click ();

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();




            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("(//span[text()='Find Retailers'])[1]")).Click ();


            //    Thread.Sleep(2000);
            //    driver.FindElement(By.XPath("")).Click();


            Thread.Sleep (3000);
            string text1 = driver.FindElement (By.XPath ("//h1[text()='Tide Clean Breeze Powder']")).Text;

            Thread.Sleep (3000);

            if(text1.Contains ("Tide Clean Breeze Powder"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }

            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");


            Assert.Pass ();

            //driver.Quit ();
            }
        [Test]
        public void Test7()
            {


             //IWebDriver driver = new FirefoxDriver ();
             driver.Navigate ().GoToUrl ("https://tide.com/en-us");
             //driver.Manage ().Window.Maximize ();
             

             Thread.Sleep (2000);
             driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();

             //Thread.Sleep(2000);
             //driver.FindElement(By.XPath("//a[@class='menu-item-title event_menu_click ' and @href='/en-us/shop']")).Click();


             Thread.Sleep (2000);
            driver.FindElement (By.CssSelector ("a[href='/en-us/our-commitment']")).Click ();


            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("")).Click();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='button-link event_button_click secondary' and @href='/en-us/our-commitment/a-load-of-good']")).Click ();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();


            Thread.Sleep (3000);
            string text1 = driver.FindElement (By.CssSelector ("div[class='richtext-container ']>h3")).Text;

            Thread.Sleep (3000);

            if(text1.Contains ("1. Manufacturing"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }



            Assert.Pass ();

            //driver.Quit ();
            }



            [Test]
            public void Testjjj()
                {


                //IWebDriver driver = new FirefoxDriver ();
                driver.Navigate ().GoToUrl ("https://tide.com/en-us");
                //driver.Manage ().Window.Maximize ();

                Thread.Sleep (2000);
                driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();



                Thread.Sleep (2000);
                driver.FindElement (By.CssSelector ("a[href='/en-us/how-to-wash-clothes']")).Click ();




                //Thread.Sleep(2000);
                //driver.FindElement(By.XPath("")).Click();


                Thread.Sleep (2000);
                driver.FindElement (By.XPath ("//a[@class='button-link event_button_click secondary' and @href='/en-us/how-to-wash-clothes/washing-machine-101']")).Click ();


                Thread.Sleep (2000);
                driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

                

            Thread.Sleep (3000);
            string text8 = driver.FindElement (By.XPath ("//a[@class='article-preview-title' and @href='/en-us/how-to-wash-clothes/washing-machine-101/how-to-use-an-he-washer']")).Text;

            Thread.Sleep (3000);

            if(text8.Contains ("How to Use an HE Washer"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }

                ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");

            Assert.Pass ();

            //driver.Quit ();
            }




        [Test]
        public void Test9()
            {

            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();



            Thread.Sleep (2000);
            driver.FindElement (By.CssSelector ("a[href='/en-us/latest-news']")).Click ();



            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("")).Click();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='article-preview-link' and @href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-spring-meadow']")).Click ();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();


            Thread.Sleep (3000);
            string text1 = driver.FindElement (By.XPath ("//div[@class='description']")).Text;

            Thread.Sleep (3000);

            if(text1.Contains ("From America's #1 Trusted Detergent Brand*"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }



                ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");
            Assert.Pass ();

            //driver.Quit ();
            }



        [Test]
        public void Test10()
            {

            //////IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            ////driver.Manage ().Window.Maximize ();

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();



            Thread.Sleep (2000);
            driver.FindElement (By.CssSelector ("a[href='/en-us/coupons-and-rewards']")).Click ();



            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//button[@class='sticker_close' and @type='button' and @aria-label='Close Sticker']")).Click ();

            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("")).Click();


            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='event_internal_link' and @href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click ();








            ((ITakesScreenshot)driver).GetScreenshot ().SaveAsFile (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\new.png");


            Assert.Pass ();

            //driver.Quit ();
            }

        public void Test11()
            {

            //IWebDriver driver = new FirefoxDriver ();
            driver.Navigate ().GoToUrl ("https://tide.com/en-us");
            //driver.Manage ().Window.Maximize ();

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click ();



            Thread.Sleep (2000);
            driver.FindElement (By.CssSelector ("a[href='https://us.pg.com']")).Click ();




            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).Click ();






            Thread.Sleep (2000);

            driver.FindElement (By.XPath ("//input[@id='3w54FOQ6wXdcrOdemgaQTD' and @class='search__input js-search-field']")).SendKeys ("Press Kits");

            //JavascriptExecutor j = (JavascriptExecutor)driver;
            //j.executeScript("window.scrollBy(0,500)");



            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep (5000);
            js.ExecuteScript ("window.scrollBy(0,500)");

            Thread.Sleep (2000);
            driver.FindElement (By.XPath ("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']")).Click ();

            //driver.FindElement(By.XPath("//a[@class='search-result__link' and @href='https://news.pg.com/press-kits/default.aspx']/h2")).SendKeys(Keys.Return);







            Thread.Sleep (5000);
            string text1 = driver.FindElement (By.XPath ("//span[text()='CES 2020 Press Kit']")).Text;



            if(text1.Contains ("CES 2020 Press Kit"))
                {
                Console.WriteLine ("present");
                }
            else
                {
                Console.WriteLine ("not present");
                }


            Assert.Pass ();

            //driver.Quit ();


            }





    }





    }