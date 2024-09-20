public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        List<int> list = nums1.ToList();
        List<int> list2 = nums2.ToList();
        List<int> values = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list2.Count; j++)
            {
                if (list[i] == list2[j])
                { 
                    values.Add(list[i]);
                    list2[j] =- 1;
                    break;
                }
            }
        }
        
        return values.ToArray();
    }
}
