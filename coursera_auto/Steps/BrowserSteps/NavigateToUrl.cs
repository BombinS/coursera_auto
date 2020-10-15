using System;
using TechTalk.SpecFlow;

namespace coursera_auto.Steps.BrowserSteps
{
  [Binding]
  public class NavigateToUrl
  {
    [When(@"navigate to url ""(.*)""")]
    public void WhenNavigateToUrl(string url)
    {
      Pages.Wrapper.driver.Navigate().GoToUrl(url);
    }
  }
}
