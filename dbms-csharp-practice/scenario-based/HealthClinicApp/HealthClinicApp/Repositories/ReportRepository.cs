using Microsoft.Data.SqlClient;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;
using HealthClinicApp.Reports;
using System;
using System.Collections.Generic;

namespace HealthClinicApp.Repositories;

public class ReportRepository : IReportRepository
{
    public List<RevenueReport> GetRevenueReport(DateTime from, DateTime to)
    {
        List<RevenueReport> list = new();

        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_RevenueReport", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@FromDate", from);
        cmd.Parameters.AddWithValue("@ToDate", to);

        using SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            list.Add(new RevenueReport
            {
                DoctorName = rs["Doctor"].ToString(),
                TotalRevenue = Convert.ToDecimal(rs["Revenue"])
            });
        }

        return list;
    }
}