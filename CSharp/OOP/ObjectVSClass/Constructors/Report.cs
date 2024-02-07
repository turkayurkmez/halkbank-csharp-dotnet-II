using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{

    public enum FormatType
    {
        PDF,
        Excel,
        Word

    }
    public class Report
    {
        public FormatType Format { get; set; }


        private string dataFilePath;

        public Report(string path) : this(path, FormatType.PDF)
        {
            //Format = FormatType.PDF;
            //dataFilePath = path;

        }

        public Report(string path, FormatType format)
        {
            Format = format;
            dataFilePath = path;
        }

        public void GenerateReport()
        {
            switch (Format)
            {
                case FormatType.PDF:
                    //.... yap...
                    break;
                case FormatType.Excel:
                    break;
                case FormatType.Word:
                    break;
                default:
                    break;
            }
        }




    }
}
