using HealthClinicApp.Models;
using System.Collections.Generic;

namespace HealthClinicApp.Interfaces;

public interface IVisitRepository
{
    int RecordVisit(Visit visit);
    void AddPrescriptions(int visitId, List<Prescription> prescriptions);
}