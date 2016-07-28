using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "結案功能_提案人")]
    public class 結案功能_提案人Steps
    {
        [Given(@"我有一張服務單")]
        public void Given我有一張服務單()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"單據狀態為驗收中")]
        public void Given單據狀態為驗收中()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"單據結案")]
        public void When單據結案()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"單據狀態為""(.*)""")]
        public void Then單據狀態為(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
