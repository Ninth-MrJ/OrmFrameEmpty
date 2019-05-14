namespace Orm.Framework.Services
{
    public interface IExcelWriter
    {
        ExcelExportResult Write(ExcelExporterParameter parameter);
    }
}
