using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.customer_service_call_log
{
    internal interface ICallLogManager
    {
        void AddCallLog(string customerName, string phoneNumber, string message);
        void ResizeArray();
        CallLogs[] SearchByKeyword(string keyword);
        CallLogs[] FilterByTime(DateTime startTime, DateTime endTime);
        void DisplayLogs(CallLogs[] logs);
    }
}
