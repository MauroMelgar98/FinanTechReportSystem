using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Models
{
    public class PDFReport : Report
    {
        public override void Generate()
        {
            Content = "PDF Report Content";
        }
    }
}
