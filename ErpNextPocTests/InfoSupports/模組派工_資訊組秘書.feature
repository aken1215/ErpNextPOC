Feature: 模組派工_資訊組秘書
  In order to 各模組主管可以收到各自負責的需求
  As a 資訊組秘書
  I want to 可對資訊服務單進行模組派工

Scenario: 派工
	Given 資料庫有服務單"201607001"
	And  服務單的狀態為 "模組派工" 狀態
	When 選擇派工模組"幕僚模組"
	And  派工
	Then 服務單的狀態為"資訊主管報價回覆"
