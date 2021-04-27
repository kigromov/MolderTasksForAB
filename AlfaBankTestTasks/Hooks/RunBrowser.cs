using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AlfaBankTestTasks.Hooks
{
    [Binding]
    public sealed class RunBrowser
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly Molder.Web.Steps.Steps _di;

        public RunBrowser(Molder.Web.Steps.Steps di)
        {
            _di = di;
        }

        [BeforeScenario("WebUI")]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            _di.StartBrowser();
            Console.WriteLine("StartBrowser");
        }


        [AfterScenario("WebUI")]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            _di.CloseWebPage();
            _di.CloseBrowser();
            Console.WriteLine("CloseBrowser");
        }
    }
}
