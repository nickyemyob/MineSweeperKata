using TechTalk.SpecFlow;

namespace MineSweeperKata.Spec
{
    [Binding]
    public class ShowMinesSteps
    {
        [Given(@"I have a (.*) x (.*) field with (.*) mines")]
        public void GivenIHaveAXFieldWithMines(int p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I run the metal detector over the field")]
        public void WhenIRunTheMetalDetectorOverTheField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be a field with (.*) revealed")]
        public void ThenTheResultShouldBeAFieldWithRevealed(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
