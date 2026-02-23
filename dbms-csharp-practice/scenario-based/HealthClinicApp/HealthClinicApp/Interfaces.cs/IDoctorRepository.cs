using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IDoctorRepository
{
    void AddDoctor(Doctor doctor);
    void UpdateSpecialty(int doctorId, int specialtyId);
    void DeactivateDoctor(int doctorId);
}