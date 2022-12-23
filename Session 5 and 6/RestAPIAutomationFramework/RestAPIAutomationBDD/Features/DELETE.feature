Feature: Posts page operations - DELETE

Scenario Outline: DELETE
	Given I create a new post using id '<id>', title '<title>' and author '<author>'
	When I delete the post with id '<id>', title '<title>' and author '<author>'
	Then I should be able to delete the post with '<id>', title '<title>' and author '<author>'
Examples: 
| id | title   | author    |
| 11 | title101 | author101  |