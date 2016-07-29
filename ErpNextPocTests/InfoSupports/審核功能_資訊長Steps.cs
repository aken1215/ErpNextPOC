﻿using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "審核功能_資訊長")]
    public class 審核功能_資訊長Steps
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

        [Given(@"服務單派工模組為 ""(.*)""")]
        public void Given服務單派工模組為(string p0)
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

        [Given(@"服務單服務工時為 (.*)")]
        public void Given服務單服務工時為(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"服務單報價 (.*)")]
        public void Given服務單報價(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"資訊長同意")]
        public void When資訊長同意()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Then服務單的狀態為狀態(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"服務工時修改為(.*)")]
        public void When服務工時修改為(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"服務工時為(.*)")]
        public void Then服務工時為(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"實際報價(.*)")]
        public void Then實際報價(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"資訊長不同意")]
        public void When資訊長不同意()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
