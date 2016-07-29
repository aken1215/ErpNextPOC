Feature: 查詢進度_提案人
	In order to 追蹤服務單進度
	As a 提案人
	I want to 可對資訊服務單進度進行查詢

Scenario: 查詢申請日期起訖日
	Given 資料庫有服務單
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070003 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070004 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	When 申請日期區間(起日)條件輸入"2016070001"
	And  申請日期區間(迄日)條件輸入"2016070002"
	And  呼叫查詢方法
	Then 搜尋結果為
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |

Scenario: 查詢預計完成日日期起訖日
	Given 資料庫有服務單
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070003 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070004 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	When 預計完成日日期區間(起日)條件輸入"2016070001"
	And  預計完成日日期區間(迄日)條件輸入"2016070002"
	And  呼叫查詢方法
	Then 搜尋結果為
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |

Scenario: 查詢單號區間(迄)起訖
	Given 資料庫有服務單
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070003 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070004 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	When 單號區間條件輸入"2016070001"
	And  呼叫查詢方法
	Then 搜尋結果為
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |


Scenario: 查詢單據狀態
	Given 資料庫有服務單
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070003 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070004 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	When 單據狀態條件勾選3
	And  簽核狀態條件勾選3
	And  未結案狀態條件選取3
	And  呼叫查詢方法
	Then 搜尋結果為
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |

Scenario: 查詢自身簽核單據
	Given 資料庫有服務單
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | false         | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | false         | 3       |
	| 2016070003 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | false         | 3       |
	| 2016070004 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	When 簽核條件勾選"true"
	And  呼叫查詢方法
	Then 搜尋結果為
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |

Scenario: 查詢單據部門
	Given 資料庫有服務單
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070003 | 2016070099 | VR12 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070004 | 2016070099 | VR12 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	When 申請部門條件選取"VR11"
	And  呼叫查詢方法
	Then 搜尋結果為
	| BeginDocno | EndDocno   | Dpt  | State | BeginDocdate | EndDocdate | BeginEST_cmplt_Date | EndEST_cmplt_Date | Approve_state | ApproveMyself | NoFinsh |
	| 2016070001 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
	| 2016070002 | 2016070099 | VR11 | 3     | 20160701     | 20160731   | 20160701            | 20160731          | 3             | true          | 3       |
