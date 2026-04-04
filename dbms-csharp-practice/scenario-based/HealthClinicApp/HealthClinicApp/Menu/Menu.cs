using System;
using System.Collections.Generic;
using HealthClinicApp.Models;
using HealthClinicApp.Services;

namespace HealthClinicApp.Menu;

public class Menu
{
    private readonly ClinicService service;

    public Menu(ClinicService service)
    {
        this.service = service;
    }

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine("\n====== HEALTH CLINIC MANAGEMENT ======");
            Console.WriteLine("1. Register Patient");
            Console.WriteLine("2. Search Patient");
            Console.WriteLine("3. Add Doctor");
            Console.WriteLine("4. Add Specialty");
            Console.WriteLine("5. Book Appointment");
            Console.WriteLine("6. Complete Visit (Diagnosis + Bill)");
            Console.WriteLine("7. Revenue Report");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RegisterPatientMenu();
                    break;

                case 2:
                    SearchPatientMenu();
                    break;

                case 3:
                    AddDoctorMenu();
                    break;

                case 4:
                    AddSpecialtyMenu();
                    break;

                case 5:
                    BookAppointmentMenu();
                    break;

                case 6:
                    CompleteVisitMenu();
                    break;

                case 7:
                    RevenueReportMenu();
                    break;

                case 0:
                    Console.WriteLine("Exiting system...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }

    // ================= MENU OPERATIONS =================

    private void RegisterPatientMenu()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("DOB (yyyy-mm-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());

        Console.Write("Phone: ");
        string phone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Address: ");
        string address = Console.ReadLine();

        Console.Write("Blood Group: ");
        string bg = Console.ReadLine();

        service.RegisterPatient(new Patient
        {
            FullName = name,
            DOB = dob,
            Phone = phone,
            Email = email,
            Address = address,
            BloodGroup = bg
        });

        Console.WriteLine("✔ Patient registered successfully");
    }

    private void SearchPatientMenu()
    {
        Console.Write("Enter name or phone: ");
        string keyword = Console.ReadLine();

        var patients = service.SearchPatients(keyword);

        Console.WriteLine("\n--- Search Results ---");
        foreach (var p in patients)
        {
            Console.WriteLine($"{p.PatientID} | {p.FullName} | {p.Phone}");
        }
    }

    private void AddDoctorMenu()
    {
        Console.Write("Doctor Name: ");
        string name = Console.ReadLine();

        Console.Write("Contact: ");
        string contact = Console.ReadLine();

        Console.Write("Consultation Fee: ");
        decimal fee = decimal.Parse(Console.ReadLine());

        Console.Write("Specialty ID: ");
        int sid = int.Parse(Console.ReadLine());

        service.AddDoctor(new Doctor
        {
            FullName = name,
            Contact = contact,
            ConsultationFee = fee,
            SpecialtyID = sid
        });

        Console.WriteLine("✔ Doctor added");
    }

    private void AddSpecialtyMenu()
    {
        Console.Write("Specialty Name: ");
        string name = Console.ReadLine();

        service.AddSpecialty(new Specialty
        {
            SpecialtyName = name
        });

        Console.WriteLine("✔ Specialty added");
    }

    private void BookAppointmentMenu()
    {
        Console.Write("Patient ID: ");
        int pid = int.Parse(Console.ReadLine());

        Console.Write("Doctor ID: ");
        int did = int.Parse(Console.ReadLine());

        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Time (HH:mm): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        service.BookAppointment(new Appointment
        {
            PatientID = pid,
            DoctorID = did,
            AppointmentDate = date,
            AppointmentTime = time
        });

        Console.WriteLine("✔ Appointment booked");
    }

    private void CompleteVisitMenu()
    {
        Console.Write("Appointment ID: ");
        int aid = int.Parse(Console.ReadLine());

        Console.Write("Diagnosis: ");
        string diagnosis = Console.ReadLine();

        Console.Write("Notes: ");
        string notes = Console.ReadLine();

        Console.Write("Total Bill Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        List<Prescription> prescriptions = new();

        Console.Write("Number of medicines: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Medicine {i + 1} Name: ");
            string med = Console.ReadLine();

            Console.Write("Dosage: ");
            string dosage = Console.ReadLine();

            Console.Write("Duration: ");
            string duration = Console.ReadLine();

            prescriptions.Add(new Prescription
            {
                MedicineName = med,
                Dosage = dosage,
                Duration = duration
            });
        }

        service.CompleteVisit(
            new Visit
            {
                AppointmentID = aid,
                Diagnosis = diagnosis,
                Notes = notes
            },
            prescriptions,
            amount
        );

        Console.WriteLine("✔ Visit completed and bill generated");
    }

    private void RevenueReportMenu()
    {
        Console.Write("From Date (yyyy-mm-dd): ");
        DateTime from = DateTime.Parse(Console.ReadLine());

        Console.Write("To Date (yyyy-mm-dd): ");
        DateTime to = DateTime.Parse(Console.ReadLine());

        var report = service.GetRevenueReport(from, to);

        Console.WriteLine("\n--- Revenue Report ---");
        foreach (var r in report)
        {
            Console.WriteLine($"{r.DoctorName} : ₹{r.TotalRevenue}");
        }
    }
}