Feature: 會簽功能_事業部總經理
	In order to 告知各事業部總經理有此需求
	As a 各事業部總經理
	I want to 可對服務單進行會簽功能

@各事業部總經理會簽
Scenario Outline: 各事業部總經理會簽
	Given 我有服務單單號"2016070001"
	And  服務單需求標題為"ERP系統改善"
	And  服務單需求說明為"客服系統希望能新增功能"
	And  服務單服務項目"ERP系統開發"
	And  服務單的狀態為"XXX" 狀態
	When 收到會簽通知
	And  填寫會簽意見說明<REMARK>
	And  事業部總經理會簽核准
	Then 服務單的狀態為"A事業部總經理會簽完成"狀態
	Examples: 
	| REMARK     |
	| 同意開發   |

@資訊長會簽
Scenario Outline: 資訊長會簽同意
	Given 我有服務單單號"2016070001"
	And  服務單需求標題為"ERP系統改善"
	And  服務單需求說明為"客服系統希望能新增功能"
	And  服務單服務項目"ERP系統開發"
	And  服務單的狀態為"事業部總經理會簽完成" 狀態
	When 收到會簽通知
	And  填寫會簽意見說明<REMARK>
	And  資訊長會簽核准
	Then 服務單的狀態為"資訊長會簽核准"狀態
	Examples: 
	| REMARK     |
	| 同意開發   |

	Scenario Outline: 資訊長會簽不同意
	Given 我有服務單單號"2016070001"
	And  服務單需求標題為"ERP系統改善"
	And  服務單需求說明為"客服系統希望能新增功能"
	And  服務單服務項目"ERP系統開發"
	And  服務單的狀態為"事業部總經理會簽完成" 狀態
	When 收到會簽通知
	And  填寫會簽意見說明<REMARK>
	And  資訊長會簽不核准
	Then 服務單的狀態為"資訊長會簽不核准"狀態
	Examples: 
	| REMARK      |
	| 此需求無意義|
