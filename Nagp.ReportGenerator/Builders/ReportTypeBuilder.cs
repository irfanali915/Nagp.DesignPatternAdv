
using Nagp.ReportGenerator.Enums;

namespace Nagp.ReportGenerator.Builders
{
    //Recursive generics
    public class ReportTypeBuilder<TSelf> : ReportFormatBuilder<ReportTypeBuilder<TSelf>> where TSelf : ReportTypeBuilder<TSelf>
    {
        public TSelf SetReportType(ReportType reportType)
        {
            report.ReportType = reportType;
            return (TSelf)this;
        }
    }
}
