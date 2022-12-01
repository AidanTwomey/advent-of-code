namespace day_one.console
{
    public class CalorieCalculator
    {
        public int GetMostCalorific(int top, IEnumerable<IEnumerable<int>> items) => 
            items
                .Select(g => g.Sum())
                .OrderDescending()
                .Take(top)
                .Sum();
    }
}