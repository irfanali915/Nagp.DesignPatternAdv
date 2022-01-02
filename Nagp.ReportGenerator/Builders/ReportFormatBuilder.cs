using Nagp.ReportGenerator.Factories;

namespace Nagp.ReportGenerator.Builders
{
    //Recursive generics
    public class ReportFormatBuilder<TSelf> : ReportBuilder where TSelf : ReportFormatBuilder<TSelf>
    {
        public TSelf SetHeader(string header)
        {
            report.Header = ReportFormaterFactory.Instance.GetReportFormater(report.ReportType).GetHeader(header);
            return (TSelf)this;
        }

        public TSelf SetFooter(string footer)
        {
            report.Footer = ReportFormaterFactory.Instance.GetReportFormater(report.ReportType).GetFooter(footer);
            return (TSelf)this;
        }

        public TSelf SetContent(string content)
        {
            report.Content = ReportFormaterFactory.Instance.GetReportFormater(report.ReportType).GetContent(content);
            return (TSelf)this;
        }
    }
}
