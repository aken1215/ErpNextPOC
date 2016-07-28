Feature: 派工功能_資訊主管
  In order to 明確訂出工時與報價和資訊人員
  As a  資訊主管
 I want to 可對需求進行評估工時和報價並指派資訊人員

@mytag
Scenario Outline: 資訊主管依據需求派工
	Given 我有服務單單號"2016070001"
	And  服務單需求標題為"ERP系統改善"
	And  服務單需求說明為"客服系統希望能新增功能"
	And  服務單服務項目"ERP系統開發"
	And  服務工時為<HOUR>
	And  實際報價為<MONEY>
	And  資訊人員指派<EMPNO>
	When 資訊主管派工
	Then 服務單的狀態為"資訊主管派工完成" 狀態
	Examples: 
	| HOUR | MONEY | EMPNO    |
	| 12   | 4800  | A0A100HR |
	| 24   | 9600  | 00047313 |
