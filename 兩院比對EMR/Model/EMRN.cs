using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 兩院比對EMR.Model
{
    public class EMRN
    {
        public decimal GenDate { get; set; }
        public decimal SeqNo { get; set; }
        public int? FormNo { get; set; }
        public string Clerk { get; set; }

        public decimal? SysDate { get; set; }

        public int? SysTime { get; set; }

        public string Finished { get; set; }

        public string TransNo { get; set; }
    }
}
