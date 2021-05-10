using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 兩院比對EMR.Model
{
    public static class Settings
    {
        public static bool Autorun { set; get; }
        public static Hostlocate Mainhost { set; get; }
        public static Hostlocate Awayhost { set; get; }
        static Settings()
        {
            Mainhost = new Hostlocate();
            Awayhost = new Hostlocate();
        }

        public static string filepath 
        {
            get { return System.Windows.Forms.Application.StartupPath + "\\System.ini";  } 
        }
    }
     public class Hostlocate
    {
        public  string hostname;
        public  string path;
    }
}
