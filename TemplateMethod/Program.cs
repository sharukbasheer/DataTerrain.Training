using TemplateMethod.AbstractClass;
using TemplateMethod.ConcreteClasses;

ReportGenerator pdfReport = new PdfReportGenerator();
pdfReport.GenerateReport();


ReportGenerator excelReport = new ExcelReportGenerator();
excelReport.GenerateReport();

Console.ReadKey();