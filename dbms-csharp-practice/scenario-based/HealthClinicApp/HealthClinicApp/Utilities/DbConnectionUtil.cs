using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Utilities;

public static class DbConnectionUtil
{
    private static readonly string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        return conn;
    }
}