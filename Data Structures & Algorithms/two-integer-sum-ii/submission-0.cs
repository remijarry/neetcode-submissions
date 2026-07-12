public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length -1;

        while (left < right)
        {
            var diff = numbers[right] + numbers[left];
            
            if (diff == target)
                return [left +1, right +1];
            if(diff > target)
                right--;
            else
                left++;
            
        }
        return [left +1, right +1];
    }
}
