Feature: Posts page operations - POST

Scenario Outline: POST
	Given I create a new post using id '<id>', title '<title>' and author '<author>'
	Then I should be able to post the post with id '<id>', title '<title>' and author '<author>'
Examples: 
| id | title   | author    |
| 11 | title11 | author11  |