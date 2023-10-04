Feature: Search In Google Home Page

#Test Comment in Google Feature File

Background:
Given Google Page Open
And Seach Text Box should be present and Enabled in the Google Home Page

@UAT @Regression
Scenario Outline: Search Google Home page with different keywords
	
	When User search a course with a Keyword <keyword>
	And Hit Enter Button
	Then All coursess Related to <keyword> Tutorial should be displayed

	
	Examples: 

	| <keyword> |
	| Java      |
	| SpecFlow  |
	| Selenium  |	

