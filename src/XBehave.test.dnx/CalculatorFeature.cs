namespace XBehave.test.dnx
{
    using Xbehave;

    using Xunit;

    public class CalculatorFeature
    {
        [ScenarioX]
        public void Addition()
        {
            int x = 0;
            int y = 0;
            Calculator calculator = null;
            int answer = 0;
            "Given the number 1"
                .x(() => x = 1);

            "And the number 2"
                .x(() => y = 2);

            "And a calculator"
                .x(() => calculator = new Calculator());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            "Then the answer is 3"
                .x(() => Assert.Equal(3, answer));
        }
    }
}