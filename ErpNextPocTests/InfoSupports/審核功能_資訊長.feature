Feature: 審核功能_資訊長
  In order to 讓資訊長對此服務單背書
  As a 資訊長
  I want to 可對資訊主管所評估和報價的結果進行審核動作

@CIO Check
Scenario: 資訊長同意，工時沒有調整
	Given 服務單的單號為 "201607001"
	And  需求標題為 "ERP系統改善"
	And  需求說明為 "客服系統希望能新增功能"
	And 資訊說明為 "依據需求開發"
	And 資訊主管為 "萱姐"
	And 服務單的狀態為 "核准" 狀態
	And 服務工時為 24
	And 實際報價 9600	
	When 資訊長同意
	Then 服務單的狀態為 "資訊長核准" 狀態

Scenario Outline: 資訊長同意，工時有調整
	Given 服務單的單號為 "201607001"
	And  需求標題為 "ERP系統改善"
	And  需求說明為 "客服系統希望能新增功能"
	And  派工模組為 "營業系統部"
	And 資訊主管為 "萱姐"
	And 服務單的狀態為 "資訊主管核准" 狀態
	And 資訊說明為 "依據需求開發"
	And 服務工時為 24
	And 實際報價 9600	
	When 服務工時修改為 <time>
	And 資訊長同意
	Then 服務單的狀態為 "資訊長核准" 狀態
	And 服務工時為 <time>
	And 實際報價 <money>
	Examples: 
	| time | money |
	|  20  | 8000  |
	|  16  | 6400  |


Scenario: 資訊長不同意
	Given 服務單的單號為 "201607001"
	And  需求標題為 "ERP系統改善"
	And  需求說明為 "客服系統希望能新增功能"
	And 資訊說明為 "依據需求開發"
	And 資訊主管為 "萱姐"
	And 服務單的狀態為 "核准" 狀態
	And 服務工時為 24
	And 實際報價 9600	
	When 資訊長不同意
	Then 服務單的狀態為 "資訊長不核准" 狀態