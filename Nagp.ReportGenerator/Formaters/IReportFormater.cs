namespace Nagp.ReportGenerator.Formaters
{
    public interface IReportFormater
    {
        public string GetHeader(string header);

        public string GetFooter(string footer);

        public string GetContent(string content);
    }
}
