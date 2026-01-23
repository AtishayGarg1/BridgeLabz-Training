
using System;
using System.IO;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class UsingDemo
    {
        static void Main()
        {
            try
            {
                using (StreamReader sr = new StreamReader("info.txt"))
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}
