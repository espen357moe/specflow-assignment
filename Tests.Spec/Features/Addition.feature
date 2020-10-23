Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add two numbers
	Given the first number is <num1>
	And the second number is <num2>
	When the two numbers are added
	Then the result should be <result>
	Examples: 
		| num1 | num2 | result |
		| 50   | 70   | 120    |
		| 100  | 80   | 180    |