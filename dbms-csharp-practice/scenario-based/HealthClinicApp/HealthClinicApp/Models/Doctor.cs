namespace HealthClinicApp.Models;

public class Doctor
{
    public int DoctorID { get; set; }
    public string FullName { get; set; }
    public int SpecialtyID { get; set; }
    public string Contact { get; set; }
    public decimal ConsultationFee { get; set; }
}