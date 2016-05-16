Feature: 加法計算
	In order to 避免計算錯誤
	As 數學白痴
	I want to 得到輸入數字相加的結果
	
@mytag
Scenario: 兩個數字相加
	Given 輸入50按下+
	And 輸入70
	When 按下=
	Then 畫面顯示計算結果應為120