using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class ExcelExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Excel export");
        }
    }
}
