Feature: Posts page operations - GET

Scenario Outline: GET
	Given I requested a get all posts request
	Then I should be able to get the all posts
| id | title  | author   |
| 1  | title1 | author1  |
| 2  | title2 | author2  |
| 3  | title3 | author3  |
| 4  | title4 | author4  |