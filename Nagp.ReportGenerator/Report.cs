using Nagp.ReportGenerator.Builders;
using Nagp.ReportGenerator.Enums;
using System;

namespace Nagp.ReportGenerator
{
    public class Report
    {
        public ReportType ReportType;
        public string Header;
        public string Footer;
        public string Content;

        public class Builder : ReportTypeBuilder<Builder>
        {

        }

        static readonly Lazy<Builder> builder = new(() => new());

        public static Builder New => builder.Value;

        public override string ToString()
        {
            return $"Header:\n{Header}\n\nContent:\n{Content}\n\nFooter:\n{Footer}";
        }
    }
}
