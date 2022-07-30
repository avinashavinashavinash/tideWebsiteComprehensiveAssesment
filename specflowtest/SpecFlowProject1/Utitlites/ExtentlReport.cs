//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tide11.Utitlites
//    {
//    internal class ExtentlReport
//        {

//        public static ExtentReports extent;
//        public static ExtentTest test;



//        public static void generateingReport()
//            {
//            var htmlReporter = new ExtentHtmlReporter (@"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Support\Index.html");
//            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
//            extent = new ExtentReports ();
//            extent.AttachReporter (htmlReporter);
//            }

//        public static void flushReport()
//            {
//            extent.Flush ();
//            }


//        }
    
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Gherkin.Model;
//using AventStack.ExtentReports.Reporter;
//using Gherkin.Ast;
//using Feature = AventStack.ExtentReports.Gherkin.Model.Feature;
//using Scenario = AventStack.ExtentReports.Gherkin.Model.Scenario;

//public static ExtentReports extent;
//    public static ExtentTest feature;
//    public static ExtentTest scenario;
//    public static void generateReport()
//        {
//        var htmlReporter = new ExtentHtmlReporter (@"C:\Users\suhas bhor\source\repos\OralBWebsiteAssignment\Index.html");
//        htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
//        extent = new ExtentReports ();
//        extent.AttachReporter (htmlReporter);
//        }

//    public static void featureReport()
//        {
//        feature = extent.CreateTest<Feature> (FeatureContext.Current.FeatureInfo.Title);
//        }

//    public static void scenarioReport()
//        {
//        scenario = feature.CreateNode<Scenario> (ScenarioContext.Current.ScenarioInfo.Title);
//        }

//    public static void scenarioStepReport()
//        {
//        if(ScenarioContext.Current.TestError == null)
//            {
//            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString ();
//            if(stepType == "Given")
//                scenario.CreateNode<Given> (ScenarioStepContext.Current.StepInfo.Text);
//            if(stepType == "When")
//                scenario.CreateNode<When> (ScenarioStepContext.Current.StepInfo.Text);
//            if(stepType == "Then")
//                scenario.CreateNode<Then> (ScenarioStepContext.Current.StepInfo.Text);
//            if(stepType == "And")
//                scenario.CreateNode<And> (ScenarioStepContext.Current.StepInfo.Text);
//            }
//        if(ScenarioContext.Current.TestError != null)
//            {
//            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString ();
//            if(stepType == "Given")
//                scenario.CreateNode<Given> (ScenarioStepContext.Current.StepInfo.Text).Fail (ScenarioContext.Current.TestError.Message);
//            if(stepType == "When")
//                scenario.CreateNode<When> (ScenarioStepContext.Current.StepInfo.Text).Fail (ScenarioContext.Current.TestError.Message);
//            if(stepType == "Then")
//                scenario.CreateNode<Then> (ScenarioStepContext.Current.StepInfo.Text).Fail (ScenarioContext.Current.TestError.Message);
//            if(stepType == "And")
//                scenario.CreateNode<And> (ScenarioStepContext.Current.StepInfo.Text).Fail (ScenarioContext.Current.TestError.Message);
//            }
//        }

//    public static void closeReport()
//        {
//        extent.Flush ();
//        }
//    }

//}