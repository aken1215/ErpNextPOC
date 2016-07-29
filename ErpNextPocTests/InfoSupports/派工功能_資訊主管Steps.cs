using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "派工功能_資訊主管")]
    public class 派工功能_資訊主管Steps
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
        
        [When(@"選擇執行同仁""(.*)""")]
        public void When選擇執行同仁(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"派工")]
        public void When派工()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"服務單的狀態為""(.*)"" 狀態")]
        public void Then服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
