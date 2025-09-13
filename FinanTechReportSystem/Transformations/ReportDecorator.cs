using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Transformations
{
    public abstract class ReportDecorator : Report
    {
        protected Report _report;

        public ReportDecorator(Report report)
        {
            _report = report;
        }

        public override void Generate()
        {
            _report.Generate();
            Content = _report.Content;
        }
    }

}
