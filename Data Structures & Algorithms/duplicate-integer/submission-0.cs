public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0)
            return false;
        
        HashSet<int> seen = [];

        foreach (var num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }

            seen.Add(num);
        }

        return false;
    }
}