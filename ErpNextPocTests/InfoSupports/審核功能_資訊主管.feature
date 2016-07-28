Feature: 審核功能_資訊主管
  In order to 審核提案者需求
  As a 資訊主管
  I want to 可對提案者需求進行回覆

@mytag
Scenario: 資訊主管同意
	Given 服務單的單號為 "201607001"
	And 需求標題為 "ERP系統改善"
	And 需求說明為 "客服系統希望能新增功能"
	And 派工模組為 "SM"
	When 資訊主管 "萱姐" 同意
	Then 服務單的狀態為 "資訊主管核准" 狀態

Scenario: 資訊主管不同意
	Given 服務單的單號為 "201607001"
	And 需求標題為 "ERP系統改善"
	And 需求說明為 "客服系統希望能新增功能"
	And 派工模組為 "SM"
	When 資訊主管 "萱姐" 不同意
	Then 服務單的狀態為 "資訊主管不核准" 狀態
