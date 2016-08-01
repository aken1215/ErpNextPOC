﻿Feature: 建單功能_提案人
  In order to 持續改善ERP系統功能
  As a 提案人
  I want to  可對資訊服務單填寫需求

Scenario: 新增單據－有附件
	Given 我有一張服務單
	And  填寫需求標題"電腦維修服務"
	And  填寫需求說明"我的電腦已經壞很久了"
	And  系統自動帶提案人主管"萱姐"
	And  選擇服務項目"電腦維修"
	And  選擇上傳檔案"computer.jpg"
	When 建立單據
	Then 單據狀態為建單中

Scenario: 新增單據－無附件
	Given 我有一張服務單
	And  填寫需求標題"電腦維修服務"
	And  填寫需求說明"我的電腦已經壞很久了"
	And  系統自動帶提案人主管"萱姐"
	And  選擇服務項目"電腦維修"
	When 建立單據
	Then 服務單的狀態為 "提案中" 狀態

Scenario: 修改需求標題
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "提案人申請中" 狀態
	When 我修改需求標題"電腦螢幕維修服務"
	And  修改單據
	Then 服務單的狀態為 "提案中" 狀態
	And  服務單需求標題為 "電腦螢幕維修服務"

Scenario: 修改需求說明
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "提案人申請中" 狀態
	When 我修改需求說明"螢幕跟著電腦一起壞了"
	And  修改單據
	Then 服務單的狀態為 "提案中" 狀態
	And  服務單需求說明為 "螢幕跟著電腦一起壞了"

Scenario: 修改上傳檔案
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "提案人申請中" 狀態
	And  選擇上傳檔案"computer.jpg"
	When 我修改上傳檔案"screen.jpg"
	And  修改單據
	Then 服務單的狀態為 "提案中" 狀態
	And  服務單上傳檔案為 "screen.jpg"


Scenario: 提案人修改服務項目 且提案人主管未確認 
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "提案人申請中" 狀態
	When 修改服務項目"ERP系統開發"
	And  修改單據
	Then 服務單的狀態為 "提案人申請中" 狀態
	And  服務單服務項目 "ERP系統開發"

Scenario: 提案人修改服務項目 但提案人主管已確認 
	Given 資料庫有服務單"201607001"
	And  服務單需求標題為 "ERP系統改善"
	And  服務單需求說明為 "客服系統希望能新增功能"
	And  服務單派工模組為 "營業系統部"
	And  服務單資訊主管說明為 "依據需求開發"
	And  服務單的狀態為 "建單中" 狀態
	When 修改服務項目"ERP系統開發"
	And  修改單據
	Then 服務單的狀態為 "提案人主管核准" 狀態
	And  服務單例外訊息 "核准狀態不可修改內容"

Scenario: 原服務單無附件 之後要補附件
	Given 資料庫有服務單"201607001"
	And  填寫需求標題"電腦維修服務"
	And  填寫需求說明"我的電腦已經壞很久了"
	And  系統自動帶提案人主管"萱姐"
	And  選擇服務項目"電腦維修"
	And  服務單的狀態為 "建單中" 狀態
	When 我修改上傳檔案"screen.jpg"
	And  修改單據
	Then 服務單的狀態為 "提案人申請中" 狀態
	And  服務單上傳檔案為 "screen.jpg"