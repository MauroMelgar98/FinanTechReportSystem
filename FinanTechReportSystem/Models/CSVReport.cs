using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Models
{
    public class CSVReport : Report
    {
        public override void Generate()
        {
            Content = "CSV Report Content";
        }
    }
}
