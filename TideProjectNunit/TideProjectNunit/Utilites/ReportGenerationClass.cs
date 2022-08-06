using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;




namespace SeleniumNUnitExtentReport.Config
    {
    [SetUpFixture]
    public abstract class ReportsGenerationClass
        {
        protected ExtentReports _extent;
        protected ExtentTest _test;
        public IWebDriver driver;

        [OneTimeSetUp]
        protected void Setup()
            {
            var path = System.Reflection.Assembly.GetCallingAssembly ().CodeBase;
            var actualPath = path.Substring (0, path.LastIndexOf ("bin"));
            var projectPath = new Uri (actualPath).LocalPath;
            Directory.CreateDirectory (projectPath.ToString () + "Reports");
            var reportPath = projectPath + "Reports\\ExtentReport.html";
            var htmlReporter = new ExtentHtmlReporter (reportPath);
            _extent = new ExtentReports ();
            _extent.AttachReporter (htmlReporter);
            _extent.AddSystemInfo ("Host Name", "LocalHost");
            _extent.AddSystemInfo ("Browser", "FireFox");
            _extent.AddSystemInfo ("UserName", "Avinash");


          
            }

        [OneTimeTearDown]
        protected void TearDown()
            {
            _extent.Flush ();
            }

        [SetUp]
        public void BeforeTest()
            {


            FirefoxOptions firefoxOptions = new FirefoxOptions ();
            firefoxOptions.AddArguments ("-private-window");

            driver = new FirefoxDriver (firefoxOptions);


            
            driver.Manage ().Timeouts ().ImplicitWait = TimeSpan.FromSeconds (60);
            driver.Manage ().Window.Maximize ();
            _test = _extent.CreateTest (TestContext.CurrentContext.Test.Name);
            }

        [TearDown]

        public void AfterTest()
            {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
           
            switch(status)
                {
                case TestStatus.Failed:
                    DateTime time = DateTime.Now;
                    String fileName = "Screenshot_" +time.ToString ("h_mm_ss") + ".png";
                    String screenShotPath = Capture (driver, fileName);
                    _test.Log (Status.Fail, "Fail");
                    _test.Log (Status.Fail, "Snapshot below: " +_test.AddScreenCaptureFromPath ("Screenshots\\" +fileName));
                    break;
                case TestStatus.Inconclusive:
                    break;
                case TestStatus.Skipped:
                    break;
                default:
                    break;
                }
            
            _extent.Flush ();
            driver.Quit ();
            }
        public IWebDriver GetDriver()
            {
            return driver;
            }

        public static string Capture(IWebDriver driver, String screenShotName)
            {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot ();
            var pth = System.Reflection.Assembly.GetCallingAssembly ().CodeBase;
            var actualPath = pth.Substring (0, pth.LastIndexOf ("bin"));
            var reportPath = new Uri (actualPath).LocalPath;
            Directory.CreateDirectory (reportPath + "Reports\\" + "Screenshots");
            var finalpth = pth.Substring (0, pth.LastIndexOf ("bin")) + "Reports\\Screenshots\\" +screenShotName;
            var localpath = new Uri (finalpth).LocalPath;
            screenshot.SaveAsFile (localpath, ScreenshotImageFormat.Png);
            return reportPath;
            }
        }
    }