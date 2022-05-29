public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = 0;
        int Maxsum = nums[0];
        for(int i = 0 ; i < nums.Length ; i++)
        {
            sum += nums[i];  
            
            if(sum < nums[i])
                sum = nums[i];
            
            if(Maxsum < sum)
                Maxsum = sum;
            
        }
        return Maxsum;
    }
}