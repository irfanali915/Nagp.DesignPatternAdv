using System;

namespace Nagp.ReportGenerator.Formaters
{
    public class PdfReportFormater : IReportFormater
    {

        private static readonly Lazy<PdfReportFormater> ExcelReport = new(() => new());

        public static PdfReportFormater Instance => ExcelReport.Value;

        private PdfReportFormater()
        {

        }

        public string GetContent(string content)
            => $"<PdfContent>{content}</PdfContent>";


        public string GetFooter(string footer)
            => $"<PdfFooter>{footer}</PdfFooter>";

        public string GetHeader(string header)
            => $"<PdfHeader>{header}</PdfHeader>";
    }
}
