using System;
using TechTalk.SpecFlow;

namespace ErpNextPocTests
{
    [Binding]
    [Scope(Feature = "查詢進度_提案人")]
    public class 查詢進度_提案人Steps1
    {
        [Given(@"資料庫有服務單")]
        public void Given資料庫有服務單(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"申請日期區間\(起日\)條件輸入""(.*)""")]
        public void When申請日期區間起日條件輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"申請日期區間\(迄日\)條件輸入""(.*)""")]
        public void When申請日期區間迄日條件輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"呼叫查詢方法")]
        public void When呼叫查詢方法()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"搜尋結果為")]
        public void Then搜尋結果為(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"預計完成日日期區間\(起日\)條件輸入""(.*)""")]
        public void When預計完成日日期區間起日條件輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"預計完成日日期區間\(迄日\)條件輸入""(.*)""")]
        public void When預計完成日日期區間迄日條件輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"單號區間條件輸入""(.*)""")]
        public void When單號區間條件輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"單據狀態條件勾選(.*)")]
        public void When單據狀態條件勾選(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"簽核狀態條件勾選(.*)")]
        public void When簽核狀態條件勾選(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"未結案狀態條件選取(.*)")]
        public void When未結案狀態條件選取(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"簽核條件勾選""(.*)""")]
        public void When簽核條件勾選(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"申請部門條件選取""(.*)""")]
        public void When申請部門條件選取(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
