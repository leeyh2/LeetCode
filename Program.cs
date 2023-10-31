public class Solution
{
     public static void Main(String[] args)
    {
        var nums = new[] { 0, 2, 4, 6, 7, 46, 78 };
        var index = Search(nums, 2);
        Console.WriteLine(index);

      
    }
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;

        while(left < right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target) { return mid; }
            else if (nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }
    
}