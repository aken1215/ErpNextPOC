using ErpNextPoc.Controllers.apis.InfoSupports;
using ErpNextPoc.Models.InfoSupports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "模組派工_資訊組秘書")]
    public class 模組派工_資訊組秘書Steps
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

        [When(@"選擇派工模組""(.*)""")]
        public void When選擇派工模組(InfoModuleEnum assignedInfoModule)
        {
            this.InfoSupport.AssignedInfoModule = assignedInfoModule;
        }

        [When(@"派工")]
        public void When派工()
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