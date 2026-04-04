using HealthClinicApp.Models;
using System.Collections.Generic;

namespace HealthClinicApp.Interfaces;

public interface IPatientRepository
{
    void AddPatient(Patient patient);
    void UpdatePatient(Patient patient);
    List<Patient> SearchPatients(string keyword);
}