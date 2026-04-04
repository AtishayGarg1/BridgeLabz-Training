using HealthClinicApp.Repositories;
using HealthClinicApp.Services;
using HealthClinicApp.Menu;

class Program
{
    static void Main()
    {
        var service = new ClinicService(
            new PatientRepository(),      // IPatientRepository
            new DoctorRepository(),       // IDoctorRepository
            new AppointmentRepository(),  // IAppointmentRepository
            new VisitRepository(),        // IVisitRepository
            new BillingRepository(),      // IBillingRepository
            new ReportRepository(),       // IReportRepository
            new SpecialtyRepository()     // ISpecialtyRepository
        );

        Menu menu = new Menu(service);
        menu.Start();
    }
}