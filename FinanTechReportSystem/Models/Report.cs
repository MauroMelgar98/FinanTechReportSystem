using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Models
{
    public abstract class Report
    {
        public string Content { get; set; } = string.Empty;
        public abstract void Generate();
    }
}
