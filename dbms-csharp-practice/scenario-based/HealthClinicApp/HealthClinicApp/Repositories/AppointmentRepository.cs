using Microsoft.Data.SqlClient;
using HealthClinicApp.Models;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    public void BookAppointment(Appointment a)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_BookAppointment", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@PatientID", a.PatientID);
        cmd.Parameters.AddWithValue("@DoctorID", a.DoctorID);
        cmd.Parameters.AddWithValue("@Date", a.AppointmentDate);
        cmd.Parameters.AddWithValue("@Time", a.AppointmentTime);

        cmd.ExecuteNonQuery();
    }

    public void CancelAppointment(int appointmentId)
    {
        using SqlConnection conn = DbConnectionUtil.GetConnection();
        using SqlCommand cmd = new("sp_CancelAppointment", conn);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

        cmd.ExecuteNonQuery();
    }

    public void RescheduleAppointment(Appointment appointment)
    {
        CancelAppointment(appointment.AppointmentID);

        BookAppointment(appointment);
    }

}