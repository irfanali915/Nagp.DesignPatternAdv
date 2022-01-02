namespace Nagp.ReportGenerator.Builders
{
    public class ReportBuilder
    {
        protected Report report = new();

        public Report Build()
        {
            return report;
        }
    }
}
