using Microsoft.Data.SqlClient;
using HealthClinicApp.Models;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Repositories;

public class DoctorRepository : IDoctorRepository
{
    public void AddDoctor(Doctor d)
    {
        using var conn = DbConnectionUtil.GetConnection();
        using var cmd = new SqlCommand("sp_AddDoctor", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@FullName", d.FullName);
        cmd.Parameters.AddWithValue("@Contact", d.Contact);
        cmd.Parameters.AddWithValue("@Fee", d.ConsultationFee);
        cmd.Parameters.AddWithValue("@SpecialtyID", d.SpecialtyID);

        cmd.ExecuteNonQuery();
    }

    public void UpdateSpecialty(int doctorId, int specialtyId)
    {
        using var conn = DbConnectionUtil.GetConnection();
        using var cmd = new SqlCommand("sp_UpdateDoctorSpecialty", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@DoctorID", doctorId);
        cmd.Parameters.AddWithValue("@SpecialtyID", specialtyId);

        cmd.ExecuteNonQuery();
    }

    public void DeactivateDoctor(int doctorId)
    {
        using var conn = DbConnectionUtil.GetConnection();
        using var cmd = new SqlCommand("sp_DeactivateDoctor", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@DoctorID", doctorId);
        cmd.ExecuteNonQuery();
    }
}