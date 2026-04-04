using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    class RodCuttingMain
    {
        static void Main()
        {
            int[] priceTable = { 1, 5, 8, 9, 10, 17, 17, 20 };
            int rodLength = 8;

            IRodCuttingStrategy strategy = new OptimizedCuttingStrategy();

            Console.WriteLine("Optimized Revenue: " +
                strategy.CalculateOptimalRevenue(priceTable, rodLength));

            Console.WriteLine("Non-Optimized Revenue: " +
                strategy.CalculateSimpleRevenue(priceTable, rodLength));
        }
    }

    class OptimizedCuttingStrategy : IRodCuttingStrategy
    {
        public int CalculateOptimalRevenue(int[] priceTable, int length)
        {
            if (length == 0) return 0;

            int best = int.MinValue;

            for (int cut = 1; cut <= length; cut++)
            {
                int current =
                    priceTable[cut - 1] +
                    CalculateOptimalRevenue(priceTable, length - cut);

                best = Math.Max(best, current);
            }
            return best;
        }

        public int CalculateSimpleRevenue(int[] priceTable, int length)
        {
            int midIndex = length / 2 - 1;
            return priceTable[midIndex] * 2;
        }
    }
}