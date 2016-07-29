﻿using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "審核功能_事業部總經理")]
    public class 審核功能_事業部總經理Steps
    {
        [Given(@"資料庫有服務單""(.*)""")]
        public void Given資料庫有服務單(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務單需求標題為 ""(.*)""")]
        public void Given服務單需求標題為(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務單需求說明為 ""(.*)""")]
        public void Given服務單需求說明為(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務單資訊主管說明為 ""(.*)""")]
        public void Given服務單資訊主管說明為(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Given服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"事業部總經理同意")]
        public void When事業部總經理同意()
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
