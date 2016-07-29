using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "模組派工_資訊組秘書")]
    public class 模組派工_資訊組秘書Steps
    {
        [Given(@"資料庫有服務單""(.*)""")]
        public void Given資料庫有服務單(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Given服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"選擇派工模組""(.*)""")]
        public void When選擇派工模組(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"派工")]
        public void When派工()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"服務單的狀態為""(.*)""")]
        public void Then服務單的狀態為(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
