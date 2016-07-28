using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "審核功能_資訊長")]
    public class 審核功能_資訊長Steps
    {
        [Given(@"服務單的單號為 ""(.*)""")]
        public void Given服務單的單號為(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"需求標題為 ""(.*)""")]
        public void Given需求標題為(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"需求說明為 ""(.*)""")]
        public void Given需求說明為(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"資訊說明為 ""(.*)""")]
        public void Given資訊說明為(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Given服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務工時為 (.*)")]
        public void Given服務工時為(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"實際報價 (.*)")]
        public void Given實際報價(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Then服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
