﻿using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "接單功能_資訊人員")]
    public class 接單功能_資訊人員Steps
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

        [When(@"接單")]
        public void When接單()
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
