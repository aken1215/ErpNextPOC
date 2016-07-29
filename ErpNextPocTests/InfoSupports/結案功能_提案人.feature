Feature: 結案功能_提案人
	  In order to  讓提案人能將此服務單結案
	  As a 提案人
	  I want to  結案功能

Scenario: 提案人將單據結案
	Given 資料庫有服務單"201607001"
	And  服務單的狀態為 "提案人驗收中" 狀態
	When 結案
	Then 服務單的狀態為"服務單已結案"
