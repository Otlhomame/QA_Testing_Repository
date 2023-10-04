using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUsingBDD.StepDefinitions
{
    [Binding]
    public class CSharpCornerHomeLoginStepDefinitions
    {
        IWebDriver driver;
        [Given(@"User Navigates to the CSharpCorner Homepage")]
        public void GivenUserNavigatesToTheCSharpCornerHomepage()
        {
            /*var htmlReporter = new ExtentHtmlReporter("C:\\Users\\hp\\Desktop\\C#\\PayYaBoy\\SpecFlow\\Report\\index.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            ExtentReports extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            ExtentTest featureName = extent.CreateTest<Feature>("CSharpCorner Login");
            ExtentTest testscenario = featureName.CreateNode<Scenario>("To check login functionality for the CSharpCorner homepage with invalid credentials");
            testscenario.CreateNode<Given>("User Navigates to the CSharpCorner Homepage");
            extent.Flush();*/

            //Console.WriteLine("Given Syntax Executed");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.c-sharpcorner.com/login?returnurl=/");
        }
        
        [When(@"User Enters (.*)\# as UserName and (.*) as Password")]
        public void WhenUserEntersTEstAsUserNameAndPAssAsPassword(string p0, string p1)
        {
            //Console.WriteLine("When First Syntax Executed");
            driver.FindElement(By.Id("TextBoxUserId")).SendKeys(p0);
            driver.FindElement(By.Id("TextBoxPassword")).SendKeys(p1);            
        }

        [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            //Console.WriteLine("When Second Syntax Executed");           
            driver.FindElement(By.Id("ctl00_ContentMain_ButtonSignIN")).Click();
        }
        
        [Then(@"Login should be unsuccessful")]
        public void ThenLoginShouldBeUnsuccessful()
        {
            //Console.WriteLine("Then Syntax Executed");
            Console.WriteLine(driver.Title);
            String expectedTitle = "C# Corner : Sign in";
            String actualTitle = driver.Title;
            //Assert.AreEqual(expectedTitle, actualTitle);
            Assert.That(actualTitle,Is.EqualTo(expectedTitle));
            driver.Quit();
        }
    }
}
