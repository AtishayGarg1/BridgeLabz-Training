using Microsoft.Data.SqlClient;
using HealthClinicApp.Models;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;
using System.Collections.Generic;

namespace HealthClinicApp.Repositories;

public class SpecialtyRepository : ISpecialtyRepository
{
    public void AddSpecialty(Specialty s)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new(
            "INSERT INTO Specialties (SpecialtyName, IsActive) VALUES (@n,1)", conn);

        cmd.Parameters.AddWithValue("@n", s.SpecialtyName);
        cmd.ExecuteNonQuery();
    }

    public List<Specialty> GetAllSpecialties()
    {
        List<Specialty> list = new();

        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("SELECT * FROM Specialties WHERE IsActive=1", conn);

        using SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            list.Add(new Specialty
            {
                SpecialtyID = (int)rs["SpecialtyID"],
                SpecialtyName = rs["SpecialtyName"].ToString(),
                IsActive = (bool)rs["IsActive"]
            });
        }

        return list;
    }
}