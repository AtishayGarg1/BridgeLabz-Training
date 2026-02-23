using System;

namespace HealthClinicApp.Models;

public class Visit
{
    public int VisitID { get; set; }
    public int AppointmentID { get; set; }
    public int PatientID { get; set; }
    public int DoctorID { get; set; }
    public string Diagnosis { get; set; }
    public string Notes { get; set; }
    public DateTime VisitDate { get; set; }
}