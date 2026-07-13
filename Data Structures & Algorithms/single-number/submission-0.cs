public class Solution {
    public int SingleNumber(int[] nums) 
    {
        HashSet<int> duplicates = [];

        foreach (var n in nums)
        {
            if (duplicates.Contains(n))
                duplicates.Remove(n);
            else
                duplicates.Add(n);
        }

        return duplicates.First();
    }
}
