public class TransformedArray {
    public int[] ConstructTransformedArray(int[] nums) {
        int[] ans = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int index = nums[i];
            index += i;
            index = index % nums.Length;
            index = index + nums.Length;
            index = index % nums.Length;
            ans[i] = nums[index];
        }
        return ans;
    }
}