Feature: 模組派工_資訊組秘書
  In order to 各模組主管可以收到各自負責的需求
  As a 資訊組秘書
  I want to 可對資訊服務單進行模組派工

Scenario: 派工
	Given 服務單的單號為 "201607001"
	And 需求標題為 "ERP系統改善"
	And 需求說明為 "客服系統希望能新增功能"
	And <buBoss> 會簽同意
	| buBoss |
	| 資訊長 |
	| OA總經理 |
	| 互盛總經理 |
	| 金儀總經理 |
	When 派工模組選擇 "SM"
	Then 顯示派工模組為 "SM"
