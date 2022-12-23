Feature: Posts page operations - PATCH

Scenario Outline: PATCH
	Given I updated a new post using id author '<author>'
	Then I should be able to update the post with author '<author>'
Examples: 
| author   |
| author101 |