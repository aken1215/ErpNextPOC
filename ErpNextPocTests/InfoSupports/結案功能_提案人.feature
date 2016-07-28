Feature: 結案功能_提案人
	  In order to  讓提案人能將此服務單結案
	  As a 提案人
	  I want to  結案功能

Scenario: 提案人將單據結案
	Given 我有一張服務單
	And  單據狀態為驗收中
	When 單據結案
	Then 單據狀態為"已結案"
