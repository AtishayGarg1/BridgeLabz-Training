using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class StockSpan
    {
        int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                // Remove elements smaller or equal to current price
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                // If stack is empty, span is entire range
                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

                // Push current index
                stack.Push(i);
            }

            return span;
        }

        static void Main()
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            StockSpan stockSpan = new();
            int[] result = stockSpan.CalculateSpan(prices);

            Console.WriteLine("Stock Spans:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
