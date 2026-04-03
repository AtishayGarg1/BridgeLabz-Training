
using System;
using System.IO;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class FileReadDemo
    {
        static void Main()
        {
            try
            {
                string content = File.ReadAllText("data.txt");
                Console.WriteLine(content);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
