Feature: GoToGoogleHome

This test the functionality of Google search

@tag1
Scenario: Search on Google
	Given I open the browser and Input something to search
	Then I should see the results 
