using HealthClinicApp.Reports;
using System;
using System.Collections.Generic;

namespace HealthClinicApp.Interfaces;

public interface IReportRepository
{
    List<RevenueReport> GetRevenueReport(DateTime from, DateTime to);
}