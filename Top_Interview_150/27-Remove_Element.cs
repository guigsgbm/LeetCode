namespace Top_Interview_150;

public class _27_Remove_Element
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0; 

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k++] = nums[i];
            }
        }

        return k;
    }
}