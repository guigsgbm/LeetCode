namespace Top_Interview_150;

public class _80_Remove_Duplicates_from_Sorted_Array_II
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
            return nums.Length;

        int uniqueCount = 2;

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueCount - 1] || nums[i] != nums[uniqueCount - 2])
            {
                nums[uniqueCount] = nums[i];
                uniqueCount++;
            }
        }

        return uniqueCount;
    }

}






