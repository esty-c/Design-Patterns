using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter = null;

            // Lets export the data to Excel file
            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            // Lets export the data to PDF file
            exporter = new PDFExporter();
            exporter.ExportFormatedData();
            Console.ReadLine();
        }
    }
}
