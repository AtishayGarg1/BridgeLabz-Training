public class TrionicArrayI {
    public bool IsTrionic(int[] nums) {
        int n = nums.Length;
        if (n < 4) return false;

        int i = 0;

        while (i + 1 < n && nums[i] < nums[i + 1]) i++;
        if (i == 0 || i == n - 1) return false;

        int decStart = i;
        while (i + 1 < n && nums[i] > nums[i + 1]) i++;
        if (i == decStart || i == n - 1) return false;

        while (i + 1 < n && nums[i] < nums[i + 1]) i++;

        return i == n - 1;
    }
}