using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Time
    {
        public double start { get; set; }
        public double finish { get; set; }
        public double duration { get; set; }
        public double processing { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_finish { get; set; }
    }
}
