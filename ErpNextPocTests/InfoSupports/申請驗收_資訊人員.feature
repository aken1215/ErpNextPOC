Feature: 申請驗收_資訊人員
	  In order to  讓資訊人員能在單據完成後，主動通知使用者驗收
	  As a 資訊人員
	  I want to  提供申請驗收功能


Scenario: 資訊人員執行完成後，請使用者驗收
	Given 資料庫有服務單"201607001"
	And  服務單的狀態為 "資訊同仁接單" 狀態
	When 申請驗收
	Then 服務單的狀態為"申請驗收"
