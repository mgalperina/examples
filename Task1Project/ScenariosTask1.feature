Feature: ScenariosTask1


@mytag
Scenario: searching "istqb" in Google
	Given I'm on Google Home page
	When I type istqb into a search field
		Then I should see www.anztb.org/ link in results

	Scenario Outline: searching different values in Google
	Given I'm on Google Home page
	When I type <searching words> into a search field
	Then I should see www.anztb.org/ link in results
	Examples:
	| searching words |
	| istqb           |
	| istqb nz        |
	


