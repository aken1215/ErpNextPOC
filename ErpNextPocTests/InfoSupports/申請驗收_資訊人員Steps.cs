using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "申請驗收_資訊人員")]
    public class 申請驗收_資訊人員Steps
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

        [When(@"申請驗收")]
        public void When申請驗收()
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
