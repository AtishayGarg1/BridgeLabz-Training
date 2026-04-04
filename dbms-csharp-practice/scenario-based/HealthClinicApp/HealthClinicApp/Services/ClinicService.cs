using System;
using System.Collections.Generic;
using HealthClinicApp.Models;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Reports;

namespace HealthClinicApp.Services;

public class ClinicService
{
    private readonly IPatientRepository patientRepo;
    private readonly IDoctorRepository doctorRepo;
    private readonly IAppointmentRepository appointmentRepo;
    private readonly IVisitRepository visitRepo;
    private readonly IBillingRepository billingRepo;
    private readonly IReportRepository reportRepo;
    private readonly ISpecialtyRepository specialtyRepo;

    // ================= CONSTRUCTOR (DEPENDENCY INJECTION) =================
    public ClinicService(
        IPatientRepository patientRepo,
        IDoctorRepository doctorRepo,
        IAppointmentRepository appointmentRepo,
        IVisitRepository visitRepo,
        IBillingRepository billingRepo,
        IReportRepository reportRepo,
        ISpecialtyRepository specialtyRepo)
    {
        this.patientRepo = patientRepo;
        this.doctorRepo = doctorRepo;
        this.appointmentRepo = appointmentRepo;
        this.visitRepo = visitRepo;
        this.billingRepo = billingRepo;
        this.reportRepo = reportRepo;
        this.specialtyRepo = specialtyRepo;
    }

    // ================= PATIENT MANAGEMENT =================

    // UC-1.1 Register Patient
    public void RegisterPatient(Patient patient)
    {
        patientRepo.AddPatient(patient);
    }

    // UC-1.2 Update Patient
    public void UpdatePatient(Patient patient)
    {
        patientRepo.UpdatePatient(patient);
    }

    // UC-1.3 Search Patients
    public List<Patient> SearchPatients(string keyword)
    {
        return patientRepo.SearchPatients(keyword);
    }

    // ================= DOCTOR MANAGEMENT =================

    // UC-2.1 Add Doctor
    public void AddDoctor(Doctor doctor)
    {
        doctorRepo.AddDoctor(doctor);
    }

    // UC-2.2 Update Doctor Specialty
    public void UpdateDoctorSpecialty(int doctorId, int specialtyId)
    {
        doctorRepo.UpdateSpecialty(doctorId, specialtyId);
    }

    // UC-2.4 Deactivate Doctor
    public void DeactivateDoctor(int doctorId)
    {
        doctorRepo.DeactivateDoctor(doctorId);
    }

    // ================= SPECIALTY MANAGEMENT =================

    // UC-6.1 Add Specialty
    public void AddSpecialty(Specialty specialty)
    {
        specialtyRepo.AddSpecialty(specialty);
    }

    // UC-6.1 View Specialties
    public List<Specialty> GetAllSpecialties()
    {
        return specialtyRepo.GetAllSpecialties();
    }

    // ================= APPOINTMENT SCHEDULING =================

    // UC-3.1 Book Appointment
    public void BookAppointment(Appointment appointment)
    {
        appointmentRepo.BookAppointment(appointment);
    }

    // UC-3.3 Cancel Appointment
    public void CancelAppointment(int appointmentId)
    {
        appointmentRepo.CancelAppointment(appointmentId);
    }

    // UC-3.4 Reschedule Appointment
    public void RescheduleAppointment(Appointment appointment)
    {
        appointmentRepo.RescheduleAppointment(appointment);
    }

    // ================= VISIT + MEDICAL RECORDS =================

    // UC-4.1 + UC-4.3 + UC-5.1 (TRANSACTIONAL FLOW)
    public void CompleteVisit(
        Visit visit,
        List<Prescription> prescriptions,
        decimal billAmount)
    {
        // 1. Record visit
        int visitId = visitRepo.RecordVisit(visit);

        // 2. Add prescriptions (1-to-many)
        visitRepo.AddPrescriptions(visitId, prescriptions);

        // 3. Generate bill
        billingRepo.GenerateBill(visitId, billAmount);
    }

    // ================= BILLING & PAYMENTS =================

    // UC-5.2 Record Payment
    public void RecordPayment(int billId, decimal amount, string paymentMode)
    {
        billingRepo.RecordPayment(billId, amount, paymentMode);
    }

    // ================= REPORTS =================

    // UC-5.4 Revenue Report
    public List<RevenueReport> GetRevenueReport(DateTime fromDate, DateTime toDate)
    {
        return reportRepo.GetRevenueReport(fromDate, toDate);
    }
}