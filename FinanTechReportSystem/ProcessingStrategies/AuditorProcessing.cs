using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.ProcessingStrategies
{
    public class AuditorProcessing : IProcessingStrategy
    {
        public Report Process(Report report)
        {
            report.Content += "\n[Reporte Auditor Agregado]";
            return report;
        }
    }
}
