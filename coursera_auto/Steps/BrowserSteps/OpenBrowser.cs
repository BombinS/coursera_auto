using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace coursera_auto.Steps.BrowserSteps
{
  [Binding]
  public class OpenBrowser
  {
    [Given(@"the Chrome browser is opened")]
    public void GivenTheChromeBrowserIsOpened()
    {
      Assert.IsNull(Pages.Wrapper.driver);
      new Helpers.InitBrowser(Helpers.Enums.BrowserId.Chrome);
      Assert.IsNotNull(Pages.Wrapper.driver);
    }
  }
}
