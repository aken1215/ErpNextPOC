﻿Feature: 審核功能_事業部總經理
  In order to 讓事業部總經理對此服務單背書
  As a 事業部總經理
  I want to 可對服務單報價的金額和時間作確認的動作

@Bu Boss Check
Scenario: 事業部總經理同意
	Given 服務單的單號為 "201607001"
	And  需求標題為 "ERP系統改善"
	And  需求說明為 "客服系統希望能新增功能"
	And 資訊說明為 "依據需求開發"
	And 服務工時為 24
	And 實際報價 9600
	And 服務單的狀態為 "資訊長核准" 狀態
	When 事業部總經理同意
	Then 服務單的狀態為 "事業部總經理核准" 狀態
