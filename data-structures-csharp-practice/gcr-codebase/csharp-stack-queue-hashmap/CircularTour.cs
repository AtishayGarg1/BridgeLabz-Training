using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class CircularTour
    {
        static int FindStartingPump(int[] petrol, int[] distance)
        {
            int n = petrol.Length;

            for (int start = 0; start < n; start++)
            {
                Queue<int> queue = new Queue<int>();
                int currentPetrol = 0;
                int count = 0;
                int index = start;

                while (count < n)
                {
                    currentPetrol += petrol[index] - distance[index];
                    queue.Enqueue(index);

                    if (currentPetrol < 0)
                        break;

                    index = (index + 1) % n;
                    count++;
                }

                if (count == n && currentPetrol >= 0)
                    return start;
            }

            return -1;
        }

        static void Main()
        {
            int[] petrol = { 6, 3, 7 };
            int[] distance = { 4, 6, 3 };

            int start = FindStartingPump(petrol, distance);
            Console.WriteLine("Starting Pump Index: " + start);
        }
    }
}
