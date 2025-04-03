using System;
using System.Collections.Generic;
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
        public string GoodsName { get; set; }
        public string SerialNiumber { get; set; }
        public string DeclaretedDefect { get; set; }
        public string ProducrAssembly { get; set; }


    }
}
