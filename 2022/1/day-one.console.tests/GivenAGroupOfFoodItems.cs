using Shouldly;

namespace day_one.console.tests;

public class GivenAGroupOfFoodItems
{
    [Theory]
    [InlineData(1, 24000)]
    [InlineData(3, 45000)]
    public void When_GetMostCalorific_Then_Return(int top, int expected)
    {
        
            var items = new []{
                new []{1000, 2000, 3000},
                new []{4000},
                new []{5000,6000},
                new []{7000,8000,9000},
                new []{10000}
            };

            var calcaultor = new CalorieCalculator();

            calcaultor.GetMostCalorific(top, items).ShouldBe(expected);
    }
}

