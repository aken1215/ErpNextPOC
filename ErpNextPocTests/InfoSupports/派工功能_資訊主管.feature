﻿Feature: 派工功能_資訊主管
  In order to 明確訂出工時與報價和資訊人員
  As a  資訊主管
 I want to 可對需求進行評估工時和報價並指派資訊人員

Scenario: 資訊主管依據需求派工
	Given 資料庫有服務單"201607001"
	And  服務單的狀態為 "資訊主管報價回覆" 狀態
	When 選擇執行同仁"00037313"
	And  派工
	Then 服務單的狀態為"資訊主管派工" 狀態

