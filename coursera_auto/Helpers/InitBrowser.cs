using OpenQA.Selenium.Chrome;

namespace coursera_auto.Helpers
{
  public class InitBrowser
  {
    public InitBrowser(Enums.BrowserId browserId) 
    {
      switch (browserId)
      {
        case Enums.BrowserId.Chrome:
          Pages.Wrapper.driver = new ChromeDriver(System.AppDomain.CurrentDomain.BaseDirectory);
          break;
        default:
          break;
      }
    }
  }
}
