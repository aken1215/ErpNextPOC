using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "接單功能_資訊人員")]
    public class 接單功能_資訊人員Steps
    {
        [Given(@"單據狀態為以報價回覆")]
        public void Given單據狀態為以報價回覆()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"接單")]
        public void When接單()
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
