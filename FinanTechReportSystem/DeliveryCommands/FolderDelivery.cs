using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.DeliveryCommands
{
    public class FolderDelivery : IDeliveryCommand
    {
        public void Execute(Report report)
        {
            Console.WriteLine("Sending report via Folder...");
            Console.WriteLine(report.Content);
        }
    }
}
