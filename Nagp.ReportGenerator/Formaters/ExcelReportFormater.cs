using System;

namespace Nagp.ReportGenerator.Formaters
{
    public class ExcelReportFormater : IReportFormater
    {
        private static readonly Lazy<ExcelReportFormater> ExcelReport = new(() => new());

        public static ExcelReportFormater Instance => ExcelReport.Value;

        private ExcelReportFormater()
        {

        }

        public string GetContent(string content)
            => $"<ExcelContent>{content}</ExcelContent>";


        public string GetFooter(string footer)
            => $"<ExcelFooter>{footer}</ExcelFooter>";

        public string GetHeader(string header)
            => $"<ExcelHeader>{header}</ExcelHeader>";
    }
}
