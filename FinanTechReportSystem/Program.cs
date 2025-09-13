using FinanTechReportSystem.DeliveryCommands;
using FinanTechReportSystem.Facade;
using FinanTechReportSystem.Factories;
using FinanTechReportSystem.Models;
using FinanTechReportSystem.ProcessingStrategies;
using FinanTechReportSystem.Transformations;

class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>
        {
            new User { Name = "Paul", Role = "Ejecutivo" },
            new User { Name = "Mauricio", Role = "Analista" },
            new User { Name = "Eduardo", Role = "Auditor" }
        };

        var data = new Data { RawData = "Indicadores financieros agregados" };
        var facade = new ReportFacade();

        foreach (var user in users)
        {
            var config = RoleReportConfiguration.ForRole(user.Role);
            if (config == null)
            {
                Console.WriteLine($"Rol desconocido: {user.Role}");
                continue;
            }

            var report = config.Factory.CreateReport(data);
            var decoratedReport = config.DecoratorFactory(report);

            facade.GenerateAndDeliver(
                user,
                data,
                config.Factory,
                new List<IProcessingStrategy> { config.Strategy },
                new List<ReportDecorator> { decoratedReport },
                config.Delivery
            );
        }
    }
}
