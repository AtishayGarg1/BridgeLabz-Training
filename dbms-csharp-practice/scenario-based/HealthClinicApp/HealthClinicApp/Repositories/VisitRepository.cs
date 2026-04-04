using Microsoft.Data.SqlClient;
using HealthClinicApp.Models;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;
using System.Collections.Generic;

namespace HealthClinicApp.Repositories;

public class VisitRepository : IVisitRepository
{
    public int RecordVisit(Visit visit)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_RecordVisit", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AppointmentID", visit.AppointmentID);
        cmd.Parameters.AddWithValue("@Diagnosis", visit.Diagnosis);
        cmd.Parameters.AddWithValue("@Notes", visit.Notes);

        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public void AddPrescriptions(int visitId, List<Prescription> prescriptions)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();

        foreach (var p in prescriptions)
        {
            using SqlCommand cmd = new("INSERT INTO Prescriptions VALUES (@vid,@med,@dos,@dur)", conn);

            cmd.Parameters.AddWithValue("@vid", visitId);
            cmd.Parameters.AddWithValue("@med", p.MedicineName);
            cmd.Parameters.AddWithValue("@dos", p.Dosage);
            cmd.Parameters.AddWithValue("@dur", p.Duration);

            cmd.ExecuteNonQuery();
        }
    }
}