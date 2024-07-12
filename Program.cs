// See https://aka.ms/new-console-template for more information

using POC.LeetCodeTestApp.challenges;

main();

static void main()
{
    //int[] nums = [-1, -2, -3, -4, -5, -10,-5,-1,14,2,5,6,8,7,-1,5,-3];
    //int[] nums = [3,3];
    int[] nums = [3, 2, 3];
    int[] numbers = TwoSumChallenge.TwoSum(nums, 6);
    Console.WriteLine($"Números Ordenados [{string.Join(',', numbers)}]");
}

