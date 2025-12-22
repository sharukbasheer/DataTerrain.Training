using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for Excel report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as Excel...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as Excel file.");
        }
    }
}
