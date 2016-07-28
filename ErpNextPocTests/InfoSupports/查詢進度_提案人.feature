Feature: 查詢進度_提案人
	In order to 追蹤服務單進度
	As a 提案人
	I want to 可對資訊服務單進度進行查詢

@mytag
@目前條件共有:單號區間、模組(下拉)、申請事業部(下拉)、申請部門(下拉)、單據狀態(勾選-可複選)、
@申請日期區間、核準日期區間、實際完成日日期區間、預計完成日日期區間、驗收日期區間、發票日期區間、
@簽核狀態(勾選-可複選)、簽核(勾選)、未結案月份(勾選-單選)、資訊組主管是否已會簽申請(下拉)
@共22個條件


@提案人需用到的條件 
@單號區間、申請部門、單據狀態(勾選)、申請日期區間、預計完成日區間、簽核狀態(勾選)、簽核(勾選)、未結案狀態(選取)

@使用outline方式查詢
Scenario Outline: 依據所輸入的查詢條件查詢資料
	Given 單號區間(起)條件輸入<BeginDocno>
	And 單號區間(迄)條件輸入<EndDocno>
	And 申請部門條件選取<Dpt>
	And 單據狀態條件勾選<State>
	And 申請日期區間(起日)條件輸入<BeginDocdate>
	And 申請日期區間(迄日)條件輸入<EndDocdate>
	And 預計完成日日期區間(起日)條件輸入<BeginEST_cmplt_Date>
	And 預計完成日日期區間(迄日)條件輸入<EndEST_cmplt_Date>
	And 簽核狀態條件勾選<Approve_state>
	And 簽核條件勾選<ApproveMyself>
	And 未結案狀態條件選取<NoFinsh>
	When 按下查詢按鈕
	Then "有正確收到查詢條件"
	Examples:  單一查詢條件
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
