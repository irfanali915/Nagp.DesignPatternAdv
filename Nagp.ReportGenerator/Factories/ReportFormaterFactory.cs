using Nagp.ReportGenerator.Enums;
using Nagp.ReportGenerator.Formaters;
using System;

namespace Nagp.ReportGenerator.Factories
{
    public class ReportFormaterFactory
    {

        private static readonly Lazy<ReportFormaterFactory> ExcelReport = new(() => new());

        public static ReportFormaterFactory Instance => ExcelReport.Value;

        private ReportFormaterFactory()
        {

        }

        public IReportFormater GetReportFormater(ReportType reportType)
        {
            return reportType switch
            {
                ReportType.Pdf => PdfReportFormater.Instance,
                ReportType.Excel => ExcelReportFormater.Instance,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
