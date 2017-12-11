Feature: ShowMines
	As a minesweeper
	I want to see where mines are on the field

@mytag
Scenario: See where mines are
	Given I have a 2 x 2 field with 1 mines
	When I run the metal detector over the field
	Then the result should be a field with 1 revealed
