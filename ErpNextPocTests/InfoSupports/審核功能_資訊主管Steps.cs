﻿using ErpNextPoc.Controllers.apis.InfoSupports;
using ErpNextPoc.Models.InfoSupports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "審核功能_資訊主管")]
    public class 審核功能_資訊主管Steps
    {
        private InfoSupport InfoSupport { get; set; }

        private InfoSupportController InfoSupportController { get; set; }

        [Given(@"資料庫有服務單""(.*)""")]
        public void Given資料庫有服務單(string docno)
        {
            this.InfoSupport = new InfoSupport(docno);
        }

        [Given(@"服務單需求標題為 ""(.*)""")]
        public void Given服務單需求標題為(string title)
        {
            this.InfoSupport.Title = title;
        }

        [Given(@"服務單需求說明為 ""(.*)""")]
        public void Given服務單需求說明為(string description)
        {
            this.InfoSupport.Description = description;
        }

        [Given(@"服務單派工模組為 ""(.*)""")]
        public void Given服務單派工模組為(InfoModuleEnum assignedInfoModule)
        {
            this.InfoSupport.AssignedInfoModule = assignedInfoModule;
        }

        [Given(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Given服務單的狀態為狀態(InfoSupportEnum state)
        {
            this.InfoSupport.State = state;
        }

        [Given(@"服務單存入資料庫中")]
        public void Given服務單存入資料庫中()
        {
            this.InfoSupportController.Create(this.InfoSupport);
        }

        [When(@"資訊主管同意")]
        public void When資訊主管同意()
        {
            this.InfoSupportController.ApproveToNextState(this.InfoSupport);
        }

        [When(@"資訊主管不同意")]
        public void When資訊主管不同意()
        {
            this.InfoSupportController.Reject(this.InfoSupport);
        }

        [Then(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Then服務單的狀態為狀態(InfoSupportEnum expected)
        {
            var actual = this.InfoSupport.State;

            Assert.AreEqual(expected, actual);
        }
    }
}