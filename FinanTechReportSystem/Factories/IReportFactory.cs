using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Factories
{
    public interface IReportFactory
    {
        Report CreateReport(Data data);
    }
}
