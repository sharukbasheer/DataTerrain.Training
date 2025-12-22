using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for PDF report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as PDF...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as PDF file.");
        }
    }
}
