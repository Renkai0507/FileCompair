using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Model;

namespace 兩院比對EMR.Helper
{
    class PublicMethod
    {
        public static string pathhead(Hostlocate locate)
        {
            return @"\\" + locate.hostname.Trim() + @"\" + locate.path.Replace(':', '$').Trim();
        }
        public static string pathdate(DateTime date)
        {
            return @"\" + date.Year + @"\" + date.Month.ToString("00") +
                    @"\" + date.Day.ToString("00");
        }
    }
}
