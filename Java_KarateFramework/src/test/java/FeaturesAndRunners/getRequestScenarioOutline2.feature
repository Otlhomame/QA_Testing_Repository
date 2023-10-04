
Feature: Fetching Details

@RegressionTest
Scenario Outline: To test the correctness of GET Request for different WebPages

Given url 'https://reqres.in/api/users/<id>'
When method GET
Then status 200
And print response

Examples:

|id|
|1|
|2|
|3|
|4|
|5|