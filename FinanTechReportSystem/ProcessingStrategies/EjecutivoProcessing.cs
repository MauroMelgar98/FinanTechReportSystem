using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.ProcessingStrategies
{
    public class EjecutivoProcessing : IProcessingStrategy
    {
        public Report Process(Report report)
        {
            report.Content += "\n[Reporte Ejecutivo Agregado]";
            return report;
        }
    }
}
