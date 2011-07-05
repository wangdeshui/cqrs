// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.6.1.0
//      SpecFlow Generator Version:1.6.0.0
//      Runtime Version:4.0.30319.431
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Example.Cashier
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.6.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Addition")]
    public partial class AdditionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateOrder.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Addition", "In order to keep my job\r\nAs a cashier\r\nI want to allow customers to update their " +
                    "orders", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add an item to the order")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void AddAnItemToTheOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add an item to the order", new string[] {
                        "domain"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("the manager has set up the menu");
#line 9
 testRunner.And("I have placed an order for a small latte, whole milk");
#line 10
 testRunner.When("I add a large latte, skim milk, double shot");
#line 11
 testRunner.Then("the updated order has two items");
#line 12
 testRunner.And("the updated order includes a small latte, whole milk");
#line 13
 testRunner.And("the updated order includes a large latte, skim milk, double shot");
#line 14
 testRunner.And("the updated order total is $15.20");
#line 15
 testRunner.And("nothing else happens");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a cancelled order")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void UpdateACancelledOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a cancelled order", new string[] {
                        "domain"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("the manager has set up the menu");
#line 20
 testRunner.And("I have placed an order for a small latte, whole milk");
#line 21
 testRunner.And("I have cancelled the order");
#line 22
 testRunner.When("I add a large latte, skim milk, double shot");
#line 23
 testRunner.Then("the aggregate state is invalid");
#line 24
 testRunner.And("the error is \"You can\'t add an item. This order is already cancelled. Place a new" +
                    " order.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a paid order")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void UpdateAPaidOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a paid order", new string[] {
                        "domain"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("the manager has set up the menu");
#line 29
 testRunner.And("I have placed an order for a small latte, whole milk");
#line 30
 testRunner.And("I have paid for the order");
#line 31
 testRunner.When("I add a large latte, skim milk, double shot");
#line 32
 testRunner.Then("the aggregate state is invalid");
#line 33
 testRunner.And("the error is \"You can\'t change this order. It\'s already paid. Place a new order.\"" +
                    "");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
