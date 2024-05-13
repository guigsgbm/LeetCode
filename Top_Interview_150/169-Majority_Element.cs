namespace Top_Interview_150;

public class _169_Majority_Element
{
    public static int MajorityElement(int[] nums)
    {
        int majority = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                majority = nums[i];
                count = 1;
            }
            else if (nums[i] == majority)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        count = 0;
        foreach (int num in nums)
        {
            if (num == majority)
            {
                count++;
            }
        }

        return count > nums.Length / 2 ? majority : -1;
    }
}
