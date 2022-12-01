namespace day_one.console
{
    public class PackParser
    {
        public static IEnumerable<IEnumerable<int>> Parse(string calories)
        {
            var calorieGroups = new List<int>();

            foreach (string v in calories.Replace('\r', ' ').Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(v))
                {
                    yield return calorieGroups;
                    calorieGroups = new List<int>();
                }
                else
                {
                    calorieGroups.Add(Int32.Parse(v));
                }
            }

            yield return calorieGroups;
        }
    }
}