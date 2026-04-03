
using System;

namespace SmartAddressDirectory.Helpers
{
    public static class ConsolePrinter
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("================================");
            Console.WriteLine(message);
            Console.WriteLine("================================");
        }
    }
}
