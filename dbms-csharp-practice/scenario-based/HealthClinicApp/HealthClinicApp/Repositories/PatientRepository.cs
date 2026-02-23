using Microsoft.Data.SqlClient;
using HealthClinicApp.Models;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;
using System.Collections.Generic;

namespace HealthClinicApp.Repositories;

public class PatientRepository : IPatientRepository
{
    public void AddPatient(Patient p)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_RegisterPatient", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@FullName", p.FullName);
        cmd.Parameters.AddWithValue("@DOB", p.DOB);
        cmd.Parameters.AddWithValue("@Phone", p.Phone);
        cmd.Parameters.AddWithValue("@Email", p.Email);
        cmd.Parameters.AddWithValue("@Address", p.Address);
        cmd.Parameters.AddWithValue("@BloodGroup", p.BloodGroup);

        cmd.ExecuteNonQuery();
    }

    public void UpdatePatient(Patient p)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_UpdatePatient", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@PatientID", p.PatientID);
        cmd.Parameters.AddWithValue("@Address", p.Address);
        cmd.Parameters.AddWithValue("@BloodGroup", p.BloodGroup);

        cmd.ExecuteNonQuery();
    }

    public List<Patient> SearchPatients(string keyword)
    {
        List<Patient> list = new();

        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_SearchPatients", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Keyword", keyword);

        using SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            list.Add(new Patient
            {
                PatientID = (int)rs["PatientID"],
                FullName = rs["FullName"].ToString(),
                Phone = rs["Phone"].ToString()
            });
        }
        return list;
    }
}