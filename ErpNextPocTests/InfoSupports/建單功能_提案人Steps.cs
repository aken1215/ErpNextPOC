using ErpNextPoc.Controllers.apis.InfoSupports;
using ErpNextPoc.Models.InfoSupports;
using ErpNextPoc.Models.InfoSupports.Models.InfoSupports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "建單功能_提案人")]
    public class 建單功能_提案人Steps
    {
        private InfoSupport InfoSupport { get; set; }

        private InfoSupportController InfoSupportController { get; set; }

        [Given(@"我有一張服務單")]
        public void Given我有一張服務單()
        {
            this.InfoSupport = new InfoSupport();
        }

        [Given(@"填寫需求標題""(.*)""")]
        public void Given填寫需求標題(string title)
        {
            this.InfoSupport.Title = title;
        }

        [Given(@"填寫需求說明""(.*)""")]
        public void Given填寫需求說明(string description)
        {
            this.InfoSupport.Description = description;
        }

        [Given(@"系統自動帶提案人主管""(.*)""")]
        public void Given系統自動帶提案人主管(string empno)
        {
            this.InfoSupport.ApplicantManager.EMPNO = empno;
        }

        [Given(@"選擇服務項目""(.*)""")]
        public void Given選擇服務項目(ServiceEnum serviceType)
        {
            this.InfoSupport.ServiceType = serviceType;
        }

        [Given(@"選擇上傳檔案""(.*)""")]
        public void Given選擇上傳檔案(string path)
        {
            this.InfoSupport.Files.Add(new FileData(path));
        }

        [When(@"建立單據")]
        public void When建立單據()
        {
            this.InfoSupportController.Create(this.InfoSupport);
        }

        [Then(@"單據狀態為建單中")]
        public void Then單據狀態為建單中()
        {
            var expected = InfoSupportEnum.建單中;

            var actual = this.InfoSupport.State;

            Assert.AreEqual(expected, actual);
        }

        [Then(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Then服務單的狀態為狀態(InfoSupportEnum expected)
        {
            var actual = this.InfoSupport.State;

            Assert.AreEqual(expected, actual);
        }

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

        [Given(@"服務單資訊主管說明為 ""(.*)""")]
        public void Given服務單資訊主管說明為(string infoManagerSuggestion)
        {
            this.InfoSupport.InfoManagerSuggestion = infoManagerSuggestion;
        }

        [Given(@"服務單的狀態為 ""(.*)"" 狀態")]
        public void Given服務單的狀態為狀態(InfoSupportEnum state)
        {
            this.InfoSupport.State = state;
        }

        [When(@"我修改需求標題""(.*)""")]
        public void When我修改需求標題(string title)
        {
            this.InfoSupport.Title = title;
        }

        [When(@"修改單據")]
        public void When修改單據()
        {
            this.InfoSupportController.Update(this.InfoSupport);
        }

        [When(@"我修改需求說明""(.*)""")]
        public void When我修改需求說明(string expected)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"服務單需求標題為 ""(.*)""")]
        public void Then服務單需求標題為(string expected)
        {
            var actual = this.InfoSupport.Title;

            Assert.AreEqual(expected, actual);
        }

        [Then(@"服務單需求說明為 ""(.*)""")]
        public void Then服務單需求說明為(string expected)
        {
            var actual = this.InfoSupport.Description;

            Assert.AreEqual(expected, actual);
        }

        [When(@"我修改上傳檔案""(.*)""")]
        public void When我修改上傳檔案(string path)
        {
            this.InfoSupport.Files.Clear();
            this.InfoSupport.Files.Add(new FileData(path));
        }

        [Then(@"服務單上傳檔案為 ""(.*)""")]
        public void Then服務單上傳檔案為(string expected)
        {
            var actual = this.InfoSupport.Files.FirstOrDefault().path;

            Assert.AreEqual(expected, actual);
        }

        [When(@"修改服務項目""(.*)""")]
        public void When修改服務項目(ServiceEnum serviceType)
        {
            this.InfoSupport.ServiceType = serviceType;
        }

        [Then(@"服務單服務項目 ""(.*)""")]
        public void Then服務單服務項目(ServiceEnum expected)
        {
            var actual = this.InfoSupport.ServiceType;

            Assert.AreEqual(expected, actual);
        }

        [Then(@"服務單例外訊息 ""(.*)""")]
        public void Then服務單例外訊息(string errorMessage)
        {
            this.InfoSupport.ErrorMessage = errorMessage;
        }
    }
}