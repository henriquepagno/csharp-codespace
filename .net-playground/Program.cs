class Program
{
    static void Main()
    {
        var solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        var result = solution.TwoSum(nums, target);

        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}