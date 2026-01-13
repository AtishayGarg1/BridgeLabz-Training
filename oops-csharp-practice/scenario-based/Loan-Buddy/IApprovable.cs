using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Loan_Buddy
{
   public  interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }
}
