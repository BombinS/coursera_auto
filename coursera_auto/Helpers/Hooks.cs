using TechTalk.SpecFlow;

namespace coursera_auto.Helpers
{
  [Binding]
  public class AfterScenario
  {
    [AfterScenario]
    public void CloseBrowser()
    {
      Pages.Wrapper.driver.Quit();
    }
  }
}
