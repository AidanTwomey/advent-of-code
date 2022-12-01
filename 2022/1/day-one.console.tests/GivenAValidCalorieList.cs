namespace day_one.console.tests;
using Shouldly;

public class GivenAValidCalorieList
{
    [Fact]
    public void When_Parse_Then_Grouped_Correctly()
    {
        var calories = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

        var parsed = PackParser.Parse(calories);

        parsed.Count().ShouldBe(5);
    }
}

