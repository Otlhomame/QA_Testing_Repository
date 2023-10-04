Feature: Fetching User Details

@SmokeTest
@RegressionTest

#User Needs to Add Tags in the feature file
#User Needs to Add Tags in the feature file 2

Scenario: To test the correctness of GET Request

Given url 'https://reqres.in/api/users/5'
When method GET
Then status 200
And print response