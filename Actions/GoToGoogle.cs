
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestAutomation.Actions
{
    public static class GoToGoogle
    {
        

        //navigates to Google Home Page
        public static void GoToGoogleHome()
        {
            //Gets the browser
            ChromeDriver driver = new ChromeDriver();
            //navigates to the home page

            driver.Navigate().GoToUrl("https://www.google.com/");
            
            IWebElement searchBox = driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input"));
            searchBox.Click();
            searchBox.SendKeys("Selenium Automation");

            IWebElement enter = driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf.emcav > div.UUbT9 > div.aajZCb > div.CqAVzb.lJ9FBc > center > input.gNO89b"));
            enter.Click();

        }
    }
}
