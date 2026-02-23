using Microsoft.Data.SqlClient;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Repositories;

public class BillingRepository : IBillingRepository
{
    public void GenerateBill(int visitId, decimal amount)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_GenerateBill", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VisitID", visitId);
        cmd.Parameters.AddWithValue("@Amount", amount);

        cmd.ExecuteNonQuery();
    }

    public void RecordPayment(int billId, decimal amount, string mode)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_RecordPayment", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@BillID", billId);
        cmd.Parameters.AddWithValue("@Amount", amount);
        cmd.Parameters.AddWithValue("@Mode", mode);

        cmd.ExecuteNonQuery();
    }
}