using FinanTechReportSystem.DeliveryCommands;
using FinanTechReportSystem.Factories;
using FinanTechReportSystem.Models;
using FinanTechReportSystem.ProcessingStrategies;
using FinanTechReportSystem.Transformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanTechReportSystem.Facade
{
    public class ReportFacade
    {
        public void GenerateAndDeliver(User user, Data data, IReportFactory factory, List<IProcessingStrategy> strategies, List<ReportDecorator> decorators, IDeliveryCommand delivery)
        {
            Report report = factory.CreateReport(data);

            foreach (var strategy in strategies)
            {
                report = strategy.Process(report);
            }

            foreach (var decorator in decorators)
            {
                decorator.Generate();
                report = decorator;
            }

            delivery.Execute(report);
        }
    }
}
