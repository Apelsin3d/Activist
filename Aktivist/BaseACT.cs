using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktivistBL
{
    public abstract class BaseACT
    {
        public string ACTNumber { get; set; }
        public string ACTDate { get; set; }
        public string Location { get; set; }
        public string DeclaretedDefect { get; set; }
        public string ProducrAssembly { get; set; }


        public abstract string GenerateDocument();

        protected string FormatDate(DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
        }
    }
}
