Feature: 接單功能_資訊人員
	  In order to  讓資訊人員在資訊主管派工後能接下該服務單
	  As a 資訊人員
	  I want to  提供接單功能

Scenario: 資訊人員接下服務單
	Given 我有一張服務單
	And  單據狀態為以報價回覆
	When 接單
	Then 單據狀態為"執行中"
