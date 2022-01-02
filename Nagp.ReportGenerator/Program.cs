using System;

namespace Nagp.ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = Report.New
                               .SetReportType(Enums.ReportType.Excel)
                               .SetContent("Hello Everyone - Report for this settings.")
                               .SetReportType(Enums.ReportType.Pdf) //Change report type in between
                               .SetHeader("Nagarro")
                               .SetFooter("About us: We are Nagarro family.")
                               .Build();

            Console.WriteLine(report);
            Console.WriteLine("\n\nEnter any key to exit.");
            Console.ReadKey();
        }
    }
}
