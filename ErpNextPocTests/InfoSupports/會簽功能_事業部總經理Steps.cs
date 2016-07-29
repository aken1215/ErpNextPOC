using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "會簽功能_事業部總經理")]
    public class 會簽功能_事業部總經理Steps
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
        
        [Given(@"會簽人包含""(.*)""")]
        public void Given會簽人包含(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"""(.*)""同意")]
        public void When同意(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"""(.*)""不同意")]
        public void When不同意(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"服務單的狀態為""(.*)""狀態")]
        public void Then服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
