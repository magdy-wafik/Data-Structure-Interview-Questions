public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentSum = 0;
        int LargestSum = nums[0];
        for (int i = 0 ; i < nums.Length ; i++)
        {
            currentSum += nums[i];
            if(currentSum < nums[i])
            {
                currentSum = nums[i];
            }
            
            if(LargestSum < currentSum)
            {
             LargestSum = currentSum ;   
            }
            
        }
        return LargestSum;
    }
}