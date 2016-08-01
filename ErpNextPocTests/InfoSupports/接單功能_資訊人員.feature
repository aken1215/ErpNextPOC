Feature: 接單功能_資訊人員
	  In order to  讓資訊人員在資訊主管派工後能接下該服務單
	  As a 資訊人員
	  I want to  提供接單功能

Scenario: 資訊人員接下服務單
	Given 資料庫有服務單"201607001"
	And  服務單的狀態為 "資訊主管報價回覆" 狀態
	When 接單
	Then 服務單的狀態為"資訊同仁接單"
