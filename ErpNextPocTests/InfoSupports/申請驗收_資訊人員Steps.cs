using ErpNextPoc.Controllers.apis.InfoSupports;
using ErpNextPoc.Models.InfoSupports;
using FluentTestCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "申請驗收_資訊人員")]
    public class 申請驗收_資訊人員Steps
    {
        private InfoSupport InfoSupport { get; set; }

        private InfoSupportController InfoSupportController { get; set; }

        [Given(@"資料庫有服務單""(.*)""")]
        public void Given資料庫有服務單(string docno)
        {
            this.InfoSupport = new InfoSupport(docno);
        }

        [Given(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Given服務單的狀態為狀態(InfoSupportEnum state)
        {
            this.InfoSupport.State = state;
        }

        [When(@"申請驗收")]
        public void When申請驗收()
        {
            this.InfoSupportController.ApproveToNextState(this.InfoSupport);
        }

        [Then(@"服務單的狀態為""(.*)""")]
        public void Then服務單的狀態為(InfoSupportEnum expected)
        {
            var actual = this.InfoSupport.State;

            Assert.AreEqual(expected, actual);
        }

    }
}
