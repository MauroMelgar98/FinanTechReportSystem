using FinanTechReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.DeliveryCommands
{
    public interface IDeliveryCommand
    {
        void Execute(Report report);
    }
}
