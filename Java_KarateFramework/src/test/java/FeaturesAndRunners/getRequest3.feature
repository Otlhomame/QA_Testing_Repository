@SmokeTest
Feature: Fetching Employee Details

Scenario: To test the correctness of GET Request while Retrieving Employment Details From Mock Rest API WebPage 

Given url 'https://dummy.restapiexample.com/api/v1/employee/1'
When method GET
Then status 200
And print response