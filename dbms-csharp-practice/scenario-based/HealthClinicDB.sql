/* =========================================================
   HEALTH CLINIC MANAGEMENT SYSTEM
   COMPLETE SQL SERVER SCRIPT
   Matches C# Repositories & ClinicService EXACTLY
   ========================================================= */

------------------------------------------------------------
-- 1. DATABASE
------------------------------------------------------------
--CREATE DATABASE HealthClinicDB;

USE HealthClinicDB;
GO
SELECT DB_NAME() AS CurrentDatabase;
SELECT 
    s.name AS SchemaName,
    p.name AS ProcedureName
FROM sys.procedures p
JOIN sys.schemas s ON p.schema_id = s.schema_id
WHERE p.name LIKE '%RegisterPatient%';
------------------------------------------------------------
-- 2. TABLES
------------------------------------------------------------

-- SPECIALTIES
CREATE TABLE Specialties (
    SpecialtyID INT IDENTITY PRIMARY KEY,
    SpecialtyName VARCHAR(100) UNIQUE NOT NULL,
    IsActive BIT DEFAULT 1
);

-- PATIENTS
CREATE TABLE Patients (
    PatientID INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(150) NOT NULL,
    DOB DATE NOT NULL,
    Phone VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(150) UNIQUE,
    Address VARCHAR(255),
    BloodGroup VARCHAR(5),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- DOCTORS
CREATE TABLE Doctors (
    DoctorID INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(150) NOT NULL,
    SpecialtyID INT NOT NULL,
    Contact VARCHAR(15),
    ConsultationFee DECIMAL(10,2),
    IsActive BIT DEFAULT 1,
    FOREIGN KEY (SpecialtyID) REFERENCES Specialties(SpecialtyID)
);

-- APPOINTMENTS
CREATE TABLE Appointments (
    AppointmentID INT IDENTITY PRIMARY KEY,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    AppointmentDate DATE NOT NULL,
    AppointmentTime TIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'SCHEDULED',
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);

-- VISITS
CREATE TABLE Visits (
    VisitID INT IDENTITY PRIMARY KEY,
    AppointmentID INT UNIQUE NOT NULL,
    Diagnosis VARCHAR(255),
    Notes VARCHAR(255),
    VisitDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID)
);

-- PRESCRIPTIONS
CREATE TABLE Prescriptions (
    PrescriptionID INT IDENTITY PRIMARY KEY,
    VisitID INT NOT NULL,
    MedicineName VARCHAR(150),
    Dosage VARCHAR(50),
    Duration VARCHAR(50),
    FOREIGN KEY (VisitID) REFERENCES Visits(VisitID)
);

-- BILLS
CREATE TABLE Bills (
    BillID INT IDENTITY PRIMARY KEY,
    VisitID INT UNIQUE NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    IsPaid BIT DEFAULT 0,
    FOREIGN KEY (VisitID) REFERENCES Visits(VisitID)
);

-- PAYMENTS
CREATE TABLE Payments (
    PaymentID INT IDENTITY PRIMARY KEY,
    BillID INT NOT NULL,
    Amount DECIMAL(10,2),
    Mode VARCHAR(20),
    PaidAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (BillID) REFERENCES Bills(BillID)
);

------------------------------------------------------------
-- 3. STORED PROCEDURES
------------------------------------------------------------

-- REGISTER PATIENT
CREATE OR ALTER PROCEDURE dbo.sp_RegisterPatient
    @FullName VARCHAR(150),
    @DOB DATE,
    @Phone VARCHAR(15),
    @Email VARCHAR(150),
    @Address VARCHAR(255),
    @BloodGroup VARCHAR(5)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Patients
    (FullName, DOB, Phone, Email, Address, BloodGroup)
    VALUES
    (@FullName, @DOB, @Phone, @Email, @Address, @BloodGroup);
END;
GO

-- UPDATE PATIENT
CREATE PROCEDURE sp_UpdatePatient
    @PatientID INT,
    @Address VARCHAR(255),
    @BloodGroup VARCHAR(5)
AS
BEGIN
    UPDATE Patients
    SET Address = @Address,
        BloodGroup = @BloodGroup
    WHERE PatientID = @PatientID;
END;
GO

-- SEARCH PATIENTS
CREATE PROCEDURE dbo.sp_SearchPatients
    @Keyword VARCHAR(100)
AS
BEGIN
    SELECT PatientID, FullName, Phone
    FROM Patients
    WHERE FullName LIKE '%' + @Keyword + '%'
       OR Phone LIKE '%' + @Keyword + '%';
END;
GO

-- ADD SPECIALTY
CREATE PROCEDURE sp_AddSpecialty
    @SpecialtyName VARCHAR(100)
AS
BEGIN
    INSERT INTO Specialties (SpecialtyName)
    VALUES (@SpecialtyName);
END;
GO

-- GET SPECIALTIES
CREATE PROCEDURE sp_GetSpecialties
AS
BEGIN
    SELECT * FROM Specialties WHERE IsActive = 1;
END;
GO

-- ADD DOCTOR
CREATE PROCEDURE sp_AddDoctor
    @FullName VARCHAR(150),
    @Contact VARCHAR(15),
    @Fee DECIMAL(10,2),
    @SpecialtyID INT
AS
BEGIN
    INSERT INTO Doctors
    (FullName, Contact, ConsultationFee, SpecialtyID)
    VALUES
    (@FullName, @Contact, @Fee, @SpecialtyID);
END;
GO

-- UPDATE DOCTOR SPECIALTY
CREATE PROCEDURE sp_UpdateDoctorSpecialty
    @DoctorID INT,
    @SpecialtyID INT
AS
BEGIN
    UPDATE Doctors
    SET SpecialtyID = @SpecialtyID
    WHERE DoctorID = @DoctorID;
END;
GO

-- DEACTIVATE DOCTOR
CREATE PROCEDURE sp_DeactivateDoctor
    @DoctorID INT
AS
BEGIN
    UPDATE Doctors
    SET IsActive = 0
    WHERE DoctorID = @DoctorID;
END;
GO

-- BOOK APPOINTMENT
CREATE PROCEDURE sp_BookAppointment
    @PatientID INT,
    @DoctorID INT,
    @Date DATE,
    @Time TIME
AS
BEGIN
    INSERT INTO Appointments
    (PatientID, DoctorID, AppointmentDate, AppointmentTime)
    VALUES
    (@PatientID, @DoctorID, @Date, @Time);
END;
GO

-- CANCEL APPOINTMENT
CREATE PROCEDURE sp_CancelAppointment
    @AppointmentID INT
AS
BEGIN
    UPDATE Appointments
    SET Status = 'CANCELLED'
    WHERE AppointmentID = @AppointmentID;
END;
GO

-- RECORD VISIT (RETURNS VisitID)
CREATE PROCEDURE sp_RecordVisit
    @AppointmentID INT,
    @Diagnosis VARCHAR(255),
    @Notes VARCHAR(255)
AS
BEGIN
    INSERT INTO Visits
    (AppointmentID, Diagnosis, Notes)
    VALUES
    (@AppointmentID, @Diagnosis, @Notes);

    SELECT SCOPE_IDENTITY();
END;
GO

-- GENERATE BILL
CREATE PROCEDURE sp_GenerateBill
    @VisitID INT,
    @Amount DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Bills (VisitID, Amount)
    VALUES (@VisitID, @Amount);
END;
GO

-- RECORD PAYMENT
CREATE PROCEDURE sp_RecordPayment
    @BillID INT,
    @Amount DECIMAL(10,2),
    @Mode VARCHAR(20)
AS
BEGIN
    INSERT INTO Payments (BillID, Amount, Mode)
    VALUES (@BillID, @Amount, @Mode);

    UPDATE Bills SET IsPaid = 1 WHERE BillID = @BillID;
END;
GO

-- REVENUE REPORT
CREATE PROCEDURE sp_RevenueReport
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SELECT 
        d.FullName AS Doctor,
        SUM(b.Amount) AS Revenue
    FROM Bills b
    JOIN Visits v ON b.VisitID = v.VisitID
    JOIN Appointments a ON v.AppointmentID = a.AppointmentID
    JOIN Doctors d ON a.DoctorID = d.DoctorID
    WHERE b.CreatedAt BETWEEN @FromDate AND @ToDate
    GROUP BY d.FullName;
END;
GO