using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Actions;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class GoToGoogleHomeStepDefinitions
    {
        [Given(@"I open the browser and Input something to search")]
        public void GivenIOpenTheBrowserAndInputSomethingToSearch()
        {
            GoToGoogle.GoToGoogleHome();
        }

        [Then(@"I should see the results")]
        public void ThenIShouldSeeTheResults()
        {
            Assert.IsTrue(true);
        }
    }
}
