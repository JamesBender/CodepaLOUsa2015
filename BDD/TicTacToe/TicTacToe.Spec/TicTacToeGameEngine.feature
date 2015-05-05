Feature: TicTacToeGameEngine
	In order to determine who won game
	As the game engine
	I am going to evaluate the board 
	And declare an outcome

Scenario: I have an empty board so there is no winner
	Given I have a tic tac toe board
	And the tic toe board is empty
	When I determine an outcome
	Then the result should be no winner yet

Scenario: I have three "X" in the top row so "X" wins
	Given I have a tic tac toe board
	And I have "X" in all the top row spot
	When I determine an outcome
	Then the reuslt should be "X" is the winner

Scenario: I have three "O" in the top row so "O" wins
	Given I have a tic tac toe board
	And I have "O" in all the top row spot
	When I determine an outcome
	Then the reuslt should be "O" is the winner

Scenario: I have a board that looks like this
	Given I have a tic tac toe board
	And the board looks like
		| col 1 | col 2 | col 3 |
		| X     | O     |       |
		| O     | X     |       |
		|       | O     | X     |
	When I determine an outcome
	Then the reuslt should be "X" is the winner