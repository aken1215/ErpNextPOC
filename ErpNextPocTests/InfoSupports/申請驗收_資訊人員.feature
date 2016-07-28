Feature: 申請驗收_資訊人員
	  In order to  讓資訊人員能在單據完成後，主動通知使用者驗收
	  As a 資訊人員
	  I want to  提供申請驗收功能


Scenario: 資訊人員執行完成後，請使用者驗收
	Given 我有一張服務單
	And  單據狀態為驗收中
	When 單據申請驗收
	Then 單據狀態為"驗收中"
	And  呼叫1次關心您通知提案人
