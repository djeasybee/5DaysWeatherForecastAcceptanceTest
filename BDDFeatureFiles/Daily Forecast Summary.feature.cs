﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BayoWeatherForecastTest.BDDFeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DailyForecastSummaryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Daily Forecast Summary.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Daily Forecast Summary", @"  As a User
  I want the Daily weather forecast to summarise and display the accumulated 3 hourly forecast for each day 
  in the following data groups;
  1. The most dominant (or current) condition of the day for city
  2. The most dominant (or current) wind speed and direction
  3. Aggregate rainfall of the day for city
  4. Minimum and maximum temperatures of the day for city
  So that I can see the rounded down values for each weather summeries.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Daily Forecast Summary")))
            {
                global::BayoWeatherForecastTest.BDDFeatureFiles.DailyForecastSummaryFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate the accumulated 3 hourly weather condition forecast summary is displayed" +
            " for each day")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Daily Forecast Summary")]
        public virtual void ValidateTheAccumulated3HourlyWeatherConditionForecastSummaryIsDisplayedForEachDay()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate the accumulated 3 hourly weather condition forecast summary is displayed" +
                    " for each day", ((string[])(null)));
#line 11
  this.ScenarioSetup(scenarioInfo);
#line 12
    testRunner.Given("I am on the 5 day Weather Forecast homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Forecast Days",
                        "Weather Condition",
                        "Wind Speed and Direction",
                        "Aggregate Rainfall",
                        "Results"});
            table1.AddRow(new string[] {
                        "Tuesday",
                        "Yes",
                        "Yes",
                        "Yes",
                        "Summary value Rounded down to the nearest value"});
            table1.AddRow(new string[] {
                        "Wednesday",
                        "Yes",
                        "Yes",
                        "Yes",
                        "Summary value Rounded down to the nearest value"});
            table1.AddRow(new string[] {
                        "Thursday",
                        "Yes",
                        "Yes",
                        "Yes",
                        "Summary value Rounded down to the nearest value"});
            table1.AddRow(new string[] {
                        "Friday",
                        "Yes",
                        "Yes",
                        "Yes",
                        "Summary value Rounded down to the nearest value"});
            table1.AddRow(new string[] {
                        "Saturday",
                        "Yes",
                        "Yes",
                        "Yes",
                        "Summary value Rounded down to the nearest value"});
#line 13
     testRunner.Then("the summersised 3_hourly weather forcast is displayed for each day rounded down t" +
                    "o the nearest value", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion