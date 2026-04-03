namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    // Helper class reserved for future extensions
    class RodCuttingUtility
    {
        public static bool IsValidInput(int[] prices, int length)
        {
            return prices != null && length > 0 && length <= prices.Length;
        }
    }
}