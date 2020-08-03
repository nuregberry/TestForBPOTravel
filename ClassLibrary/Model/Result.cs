using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Result
    {
        public string CURRENCY { get; set; }
        public string AMOUNT_CNT { get; set; }
        public string AMOUNT { get; set; }
        public string SORT { get; set; }
        public string BASE { get; set; }
        public string FULL_NAME { get; set; }
        public string LID { get; set; }
        public string FORMAT_STRING { get; set; }
        public string DEC_POINT { get; set; }
        public object THOUSANDS_SEP { get; set; }
        public string DECIMALS { get; set; }
        public DateTime DATE_UPDATE { get; set; }
    }
}
