using FinanTechReportSystem.DeliveryCommands;
using FinanTechReportSystem.Factories;
using FinanTechReportSystem.Models;
using FinanTechReportSystem.ProcessingStrategies;
using FinanTechReportSystem.Transformations;

public class RoleReportConfiguration
{
    public IReportFactory Factory { get; set; }
    public IProcessingStrategy Strategy { get; set; }
    public Func<Report, ReportDecorator> DecoratorFactory { get; set; }
    public IDeliveryCommand Delivery { get; set; }

    public static RoleReportConfiguration ForRole(string role)
    {
        return role switch
        {
            "Ejecutivo" => new RoleReportConfiguration
            {
                Factory = new PDFReportFactory(),
                Strategy = new EjecutivoProcessing(),
                DecoratorFactory = report => new WatermarkDecorator(report),
                Delivery = new EmailDelivery()
            },
            "Analista" => new RoleReportConfiguration
            {
                Factory = new ExcelReportFactory(),
                Strategy = new AnalistaProcessing(),
                DecoratorFactory = report => new EncryptionDecorator(report),
                Delivery = new FolderDelivery()
            },
            "Auditor" => new RoleReportConfiguration
            {
                Factory = new CSVReportFactory(),
                Strategy = new AuditorProcessing(),
                DecoratorFactory = report => new WatermarkDecorator(report),
                Delivery = new APIDelivery()
            },
            _ => null
        };
    }
}