using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.leveltwo
{
    internal class TimeZones
    {
        static void Main(string[] args)
        {
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;
            TimeZoneInfo gmt = TimeZoneInfo.Utc;
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcTime, gmt));
            Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime, ist));
            Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcTime, pst));
        }
    }
}
