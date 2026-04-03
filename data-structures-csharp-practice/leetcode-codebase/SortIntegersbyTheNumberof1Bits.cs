public class SortIntegersbyTheNumberof1Bits {
    public int[] SortByBits(int[] arr) {
         return arr
            .OrderBy(x => BitOperations.PopCount((uint)x))
            .ThenBy(x => x)
            .ToArray();
    }
}