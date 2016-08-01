﻿Feature: 審核功能_資訊長
  In order to 讓資訊長對此服務單背書
  As a 資訊長
  I want to 可對資訊主管所評估和報價的結果進行審核動作

Scenario: 資訊長同意，工時沒有調整
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And 服務單資訊主管說明為 "依據需求開發"
	And 服務單的狀態為 "資訊主管核準" 狀態
	And 服務單服務工時為 24
	And 服務單報價 9600	
	And  服務單存入資料庫中
	When 資訊長同意
	Then 服務單的狀態為 "資訊長核准" 狀態

Scenario: 資訊長同意，工時有調整
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "提案人主管核準" 狀態
	And  服務單服務工時為 24
	And  服務單報價 9600	
	And  服務單存入資料庫中
	When 服務工時修改為30
	And  資訊長同意
	Then 服務單的狀態為 "資訊長核准" 狀態
	And  服務工時為30
	And  實際報價9600


Scenario: 資訊長不同意
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "提案人主管核準" 狀態
	And  服務單服務工時為 24
	And  服務單報價 9600	
	And  服務單存入資料庫中
	When 資訊長不同意
	Then 服務單的狀態為 "資訊長不核准" 狀態