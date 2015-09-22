namespace XBehave.test.dnx
{
    using Xbehave;
    using Xbehave.Execution;

    using Xunit.Sdk;

    [XunitTestCaseDiscoverer("Xbehave.Execution.ScenarioDiscoverer", "xunit.execution.xbehave")]
    public class ScenarioXAttribute : ScenarioAttribute
    {
    }
}
