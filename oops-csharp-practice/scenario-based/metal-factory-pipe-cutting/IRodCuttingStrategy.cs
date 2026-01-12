namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    interface IRodCuttingStrategy
    {
        int CalculateOptimalRevenue(int[] priceTable, int length);
        int CalculateSimpleRevenue(int[] priceTable, int length);
    }
}