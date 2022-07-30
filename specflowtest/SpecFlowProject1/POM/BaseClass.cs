//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Support;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;

//namespace Tide11.POM
//    {
//    [Binding]
//    public class BaseClass
//        {

//        public static IWebDriver driver;


//        [BeforeScenario]

//        public void OpeningBrowser()
//            {
//            driver = new FirefoxDriver ();
//            }

//        [AfterScenario]
//        public void CloseBrowser()
//            {
//            driver.Quit ();
//            }

//        }
//    }

using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using Serilog;
using Serilog.Core;

using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Feature = AventStack.ExtentReports.Gherkin.Model.Feature;
using Scenario = AventStack.ExtentReports.Gherkin.Model.Scenario;

namespace Tide11.POM
    {

    [Binding]
    public class BaseClass
        {
        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;


        [BeforeFeature]

        public static void featureBrowser(FeatureContext featureContext)
            {
            feature = extents.CreateTest<Feature> (featureContext.FeatureInfo.Title);
            Log.Information ("selecting feature file {0} to run", featureContext.FeatureInfo.Title);
            }

        [BeforeScenario]
        public static void OpenBrowser(ScenarioContext scenarioContext)
            {
            scenario = feature.CreateNode<Scenario> (scenarioContext.ScenarioInfo.Title);
            Log.Information ("selecting scenario {0} to run", scenarioContext.ScenarioInfo.Title);

            driver = new FirefoxDriver ();
            }
        [BeforeTestRun]
        public static void GenerateReport()
            {
            var htmlReport = new ExtentHtmlReporter (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Utitlites\Index.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports ();
            extents.AttachReporter (htmlReport);
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch (Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration ().MinimumLevel.ControlledBy (levelSwitch: loggingLevel).WriteTo.File (
                @"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Utitlites\logs",
                outputTemplate: "{TimeSpan:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message}{NewLine}",
                rollingInterval: RollingInterval.Day).CreateLogger ();
            }

        [AfterTestRun]
        public static void CloseExtentReport()
            {
            extents.Flush ();
            }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
            {
            if(scenarioContext.TestError == null)
                {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString ();
                if(stepType == "Given")
                    scenario.CreateNode<Given> (ScenarioStepContext.Current.StepInfo.Text);
                if(stepType == "When")
                    scenario.CreateNode<When> (ScenarioStepContext.Current.StepInfo.Text);
                if(stepType == "And")
                    scenario.CreateNode<When> (ScenarioStepContext.Current.StepInfo.Text);
                if(stepType == "Then")
                    scenario.CreateNode<Then> (ScenarioStepContext.Current.StepInfo.Text);

                }
            if(scenarioContext.TestError != null)
                {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString ();
                if(stepType == "Given")
                    scenario.CreateNode<Given> (ScenarioStepContext.Current.StepInfo.Text).Fail (scenarioContext.TestError.Message);
                if(stepType == "When")
                    scenario.CreateNode<When> (ScenarioStepContext.Current.StepInfo.Text).Fail (scenarioContext.TestError.Message);
                if(stepType == "And")
                    scenario.CreateNode<When> (ScenarioStepContext.Current.StepInfo.Text).Fail (scenarioContext.TestError.Message);
                if(stepType == "Then")
                    scenario.CreateNode<Then> (ScenarioStepContext.Current.StepInfo.Text).Fail (scenarioContext.TestError.Message);
                }
            }


        [AfterScenario]

        public static void CloseBrowser()
            {
            driver.Quit ();
            }
        }
    }
