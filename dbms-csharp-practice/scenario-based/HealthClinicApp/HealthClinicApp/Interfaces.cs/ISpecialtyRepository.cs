using HealthClinicApp.Models;
using System.Collections.Generic;

namespace HealthClinicApp.Interfaces;

public interface ISpecialtyRepository
{
    void AddSpecialty(Specialty specialty);
    List<Specialty> GetAllSpecialties();
}