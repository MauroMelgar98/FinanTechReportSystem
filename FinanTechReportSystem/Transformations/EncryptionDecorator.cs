using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Transformations
{
    public class EncryptionDecorator : ReportDecorator
    {
        public EncryptionDecorator(Report report) : base(report) { }

        public override void Generate()
        {
            base.Generate();
            Content += "\n[Encryption Applied]";
        }
    }
}
