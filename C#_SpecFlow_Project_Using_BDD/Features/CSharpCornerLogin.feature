Feature: CSharpCorner Login

@Smoke
Scenario Outline: To check login functionality for the CSharpCorner homepage with invalid credentials
	Given User Navigates to the CSharpCorner Homepage
	When User Enters <uname> as UserName and <password> as Password
	And Click on the Login button
	Then Login should be unsuccessful

Examples: 

	| uname      | password |
	| T8*t45875# | PAss11   |
	| TE#$45876# | PAss12   |
	| TEst45877# | PAss13   |
	| TE--45876# | PAss17   |