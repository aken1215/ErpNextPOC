using Aurora.ErpNext.ViewModel;
using ErpNextPoc;
using FluentTestCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests.InfoSupports
{
    [Binding]
    [Scope(Feature = "建單功能_提案人")]
    public class 建單功能_提案人Steps
    {
        private InfoSupportViewModel model { get; set; }

        private IInfoSupportService service { get; set; }


        [Given(@"我有一張服務單")]
        public void Given我有一張服務單()
        {
            this.model = new InfoSupportViewModel();
        }


        [Given(@"填寫需求標題""(.*)""")]
        public void Given填寫需求標題(string title)
        {
            this.model.Title = title;
        }
        
        [Given(@"填寫需求說明""(.*)""")]
        public void Given填寫需求說明(string context)
        {
            this.model.Context= context;
        }
        
        [Given(@"系統自動帶提案人主管""(.*)""")]
        public void Given系統自動帶提案人主管(string managerEMPNO)
        {
            this.model.ManagerEMPNO = managerEMPNO;
        }
        
        [Given(@"選擇服務項目""(.*)""")]
        public void Given選擇服務項目(SeviceTypeEnum type)
        {
            this.model.ServiceType = type;
        }
        
        [Given(@"選擇上傳檔案""(.*)""")]
        public void Given選擇上傳檔案(string path)
        {
            this.model.FilePath = path;
        }
        
        [Given(@"我有服務單單號""(.*)""")]
        public void Given我有服務單單號(string docno)
        {
            this.model.Docno = docno;
        }
        
        
        [When(@"建立單據")]
        public void When建立單據()
        {
            this.service.Create(this.model);
        }
        
        [When(@"我修改需求標題""(.*)""")]
        public void When我修改需求標題(string title)
        {
            this.model.Title = title;
        }
        
        [When(@"修改單據")]
        public void When修改單據()
        {
            this.service.Update(this.model);
        }
        
        [When(@"我修改需求說明""(.*)""")]
        public void When我修改需求說明(string context)
        {
            this.model.Context = context;
        }
        
        [When(@"修改上傳檔案""(.*)""")]
        public void When修改上傳檔案(string path)
        {
            this.model.FilePath = path;
        }
        
        [When(@"修改服務項目""(.*)""")]
        public void When修改服務項目(SeviceTypeEnum type)
        {
            this.model.ServiceType = type;
        }
        
        [When(@"提案人主管的核決時間為""(.*)""")]
        public void When提案人主管的核決時間為(DateTime dt)
        {
            this.model.ManagerApproveTime = dt;
        }
        
        [When(@"選擇上傳檔案""(.*)""")]
        public void When選擇上傳檔案(string path)
        {
            this.model.FilePath = path;
        }
        
        [Then(@"單據狀態為新增")]
        public void Then單號狀態為新增()
        {
            var expected = InfoSupportStateEnum.Add;
            Assert.AreEqual(expected, this.model.State);
        }
        
        [Then(@"單據狀態為修改成功")]
        public void Then單號狀態為修改成功()
        {
            var expected = InfoSupportStateEnum.Modify;
            Assert.AreEqual(expected, this.model.State);
        }
        
        [Then(@"單據狀態為拒絕修改")]
        public void Then單號狀態為拒絕修改()
        {
            var expected = InfoSupportStateEnum.Reject;
            Assert.AreEqual(expected, this.model.State);
        }


    }
}
