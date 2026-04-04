public class DivideanArrayIntoSubarraysWithMinimumCostI {
    public int MinimumCost(int[] nums) {
        int sum = nums[0];
        int max1 = int.MaxValue;
        int max2 = int.MaxValue;
        for(int i = 1; i < nums.Length; i++){
            if(max1 > nums[i]){
                max2 = max1;
                max1 = nums[i];
            }
            else if(nums[i] < max2 ){
                max2 = nums[i];
            }
        }
        return sum + max1 + max2;
    }
}