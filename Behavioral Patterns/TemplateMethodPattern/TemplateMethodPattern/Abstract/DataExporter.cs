using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class DataExporter
    {
        public void ReadData()
        {
            Console.WriteLine("Reading the data from SqlServer");
        }

        // This will not vary as the format of report is fixed.
        public void FormatData()
        {
            Console.WriteLine("Formating the data as per requriements.");
        }

        // This may vary based on target file type choosen
        public abstract void ExportData();

        // This is the template method that the client will use.
        public void ExportFormatedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData();
        }

    }
}
