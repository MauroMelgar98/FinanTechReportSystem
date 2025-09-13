using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Factories
{
    public class PDFReportFactory : IReportFactory
    {
        public Report CreateReport(Data data)
        {
            var report = new PDFReport();
            report.Generate();
            return report;
        }
    }
}
