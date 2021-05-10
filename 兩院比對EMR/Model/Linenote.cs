using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 兩院比對EMR.Model
{
    public class Linenote
    {
        public string result;
        
       public Linenote(string reslultstr)
        {
            result = reslultstr;
        }
        public string GroupID { get { return "6"; } }
        public string Msg  { get { return result; } }
        public string InsUser { get { return "016217"; } }
        public string PlanSendTime { get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); } }
    }
}
