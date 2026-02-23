namespace HealthClinicApp.Interfaces;

public interface IBillingRepository
{
    void GenerateBill(int visitId, decimal amount);
    void RecordPayment(int billId, decimal amount, string mode);
}