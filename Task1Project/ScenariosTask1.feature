Feature: ScenariosTask1


@mytag
Scenario: searching "istqb" in Google
	Given I navigate to http://google.com url
	When I type istqb into a search field
	Then I should see www.anztb.org/ link in results

	Scenario Outline: searching different values in Google
	Given I navigate to http://google.com url
	When I type <searching words> into a search field
	Then I should see www.anztb.org/ link in results
	Examples:
	| searching words |
	| istqb           |
	| istqb nz        |
	
	Scenario: searching by a picture for the word balloon
	Given I navigate to http://google.com url
	When I upload C:\Users\Mashu\Desktop\tre\balloon_PNG584.png picture into a search field
	Then I should see balloon word in results

	Scenario: searching by a picture with the presence of the same one
	Given I navigate to http://google.com url
	When I upload C:\Users\Mashu\Desktop\tre\balloon_PNG584.png picture into a search field
	Then I should see balloon image in results

	Scenario: change the language to Maori by linktext
	Given I navigate to http://google.com url
	When I change the language to Maori
	Then I should see Atahanga link

	Scenario: searching "London" in Google
	Given I navigate to http://google.com url
	When I type London into a search field
	Then I should see the capital of England text in results

	Scenario: Forgot password link leads to the page Password retrieval
	Given I navigate to http://vk.com url
	When I click Forgot your password link
	Then I should see Password retrieval name of the page

	Scenario Outline: calculating different salary rates with different inputs
	Given I navigate to http://www.paye.net.nz/calculator.html url
	When I type <salary> into a salary field
	Then I should see <monthlySalary> for each salary rate
	Examples: 
	| salary | monthlySalary |
	| 45000  | 3,155.79      |
	| 95000  | 5,950.80      |
	| 100000 | 6,224.17      |
	| 120000 | 7,317.67      |


