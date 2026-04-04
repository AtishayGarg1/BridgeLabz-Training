using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IAppointmentRepository
{
    void BookAppointment(Appointment appointment);
    void CancelAppointment(int appointmentId);
    void RescheduleAppointment(Appointment appointment);
}