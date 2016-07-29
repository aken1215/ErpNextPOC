using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "結案功能_提案人")]
    public class 結案功能_提案人Steps
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

        [When(@"結案")]
        public void When結案()
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
