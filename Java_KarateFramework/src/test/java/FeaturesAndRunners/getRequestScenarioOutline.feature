@RegressionTest
Feature: Fetching Details

Scenario Outline: To test the correctness of GET Request for different WebPages

Given url '<testurl>'
When method GET
Then status 200
And print response

Examples:

|testurl|
|https://reqres.in/api/users/5|
|https://reqres.in/api/users/4|
|https://reqres.in/api/users/3|
|https://api.openweathermap.org/data/2.5/weather?q=London&appid=Your_API|