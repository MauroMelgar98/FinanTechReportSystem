using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Factories
{
    public class ExcelReportFactory : IReportFactory
    {
        public Report CreateReport(Data data)
        {
            var report = new ExcelReport();
            report.Generate();
            return report;
        }
    }
}
