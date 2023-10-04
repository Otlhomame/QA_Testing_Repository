using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUsingBDD.StepDefinitions
{
    [Binding]
    public class SearchInGoogleHomePageStepDefinitions
    {
        [Given(@"Google Page Open")]
        public void GivenGooglePageOpen()
        {
        }

        [Given(@"Seach Text Box should be present and Enabled in the Google Home Page")]
        public void GivenSeachTextBoxShouldBePresentAndEnabledInTheGoogleHomePage()
        {
        }

        [When(@"User search a course with a Keyword Java")]
        public void WhenUserSearchACourseWithAKeywordJava()
        {
        }

        [When(@"Hit Enter Button")]
        public void WhenHitEnterButton()
        {
        }

        [Then(@"All coursess Related to Java Tutorial should be displayed")]
        public void ThenAllCoursessRelatedToJavaTutorialShouldBeDisplayed()
        {
        }

        [When(@"User search a course with a Keyword SpecFlow")]
        public void WhenUserSearchACourseWithAKeywordSpecFlow()
        {
        }

        [Then(@"All coursess Related to SpecFlow Tutorial should be displayed")]
        public void ThenAllCoursessRelatedToSpecFlowTutorialShouldBeDisplayed()
        {
        }

        [When(@"User search a course with a Keyword <keyword>")]
        public void WhenUserSearchACourseWithAKeywordKeyword()
        {
        }

        [Then(@"All coursess Related to <keyword> Tutorial should be displayed")]
        public void ThenAllCoursessRelatedToKeywordTutorialShouldBeDisplayed()
        {
        }
    }
}
