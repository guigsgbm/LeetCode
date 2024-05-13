namespace Top_Interview_150;

public class _88_Merge_Sorted_Array
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var aux = 0;
        var temp = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            if (aux >= n)
                break;

            if (nums1[i] == 0)
            {
                nums1[i] = nums2[aux];
                aux++;
            }
        }

        for (int write = 0; write < nums1.Length; write++)
        {
            for (int sort = 0; sort < nums1.Length - 1; sort++)
            {
                if (nums1[sort] > nums1[sort + 1])
                {
                    temp = nums1[sort + 1];
                    nums1[sort + 1] = nums1[sort];
                    nums1[sort] = temp;
                }
            }
        }
    }
}
