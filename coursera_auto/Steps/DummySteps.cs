using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace coursera_auto.Steps
{
  [Binding]
  public class DummySteps
  {
    [Given(@"some dummy pattern")]
    public void GivenSomeDummyPattern()
    {
      Assert.AreEqual(true, true);
    }

    [Given(@"some another dummy pattern")]
    public void GivenSomeAnotherDummyPattern()
    {
      Assert.AreEqual(true, false);
    }

  }
}
