Feature: Fetching Open Weather Details

@SmokeTest
@IntegrationTest
Scenario: To test the correctness of GET Request And REtrieve Current Weather Report From Web Page 

Given url 'https://api.openweathermap.org/data/2.5/weather?q=London&appid=Your_API'
When method GET
Then status 200
And print response