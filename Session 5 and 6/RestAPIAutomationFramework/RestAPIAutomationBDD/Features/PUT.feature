Feature: Posts page operations - PUT

Scenario Outline: PUT
	Given I updated a new post using id '<id>', title '<title>' and author '<author>'
	Then I should be able to update the post with id '<id>', title '<title>' and author '<author>'
Examples: 
| id | title   | author    |
| 11 | title101 | author11  |