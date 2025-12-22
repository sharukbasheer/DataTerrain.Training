using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.AbstractClass
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            FetchData();
            FormatData();
            ExportReport();
        }

        protected abstract void FetchData();
        protected abstract void FormatData();
        protected abstract void ExportReport();
    }
}
