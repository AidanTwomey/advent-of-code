using Shouldly;

namespace day_five.console.tests;

public class GivenStackingInstructions
{
    [Theory]
    [InlineData(1, 'A')]
    [InlineData(2, 'A', 'B')]
    // [InlineData(@"move 10 from 9 to 7", 10,8,6)]
    public void When_Push_Then_Return_Top_1(int n, params char[] expected)
    {
        var many = new StackMany();

        many.Push(new []{'A', 'B', 'C'});
        many.Pop(n).ShouldBe(expected);
    }

    [Theory]
    [InlineData(@"move 3 from 2 to 1", 3,1,0)]
    [InlineData(@"move 10 from 9 to 7", 10,8,6)]
    public void When_Parse_Then_Return_Instructions(string instructions, int move, int from, int to)
    {
        var value = Instructions.Parse(instructions);

        value.count.ShouldBe(move);
        value.from.ShouldBe(from);
        value.to.ShouldBe(to);
    }

    [Fact]
    public void When_Execute_CrateMover9000_Then_Return_TopCrates()
    {
        var instructions = @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";

        CrateStacker.Execute(instructions, 9000).ShouldBe("CMZ");
    }


    [Fact]
    public void When_Execute_CrateMover9001_Then_Return_TopCrates()
    {
        var instructions = @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";

        CrateStacker.Execute(instructions, 9001).ShouldBe("MCD");
    }
}

