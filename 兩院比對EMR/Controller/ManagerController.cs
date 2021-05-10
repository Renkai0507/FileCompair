using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 兩院比對EMR.Helper;
using 兩院比對EMR.Model;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR.Controller
{
    class ManagerController
    {
        IRepositoryWrapper Repository;
       
        public ManagerController(IRepositoryWrapper repository)
        {
            Repository = repository;
        }        
       
        public void Update()
        {
            Properties.Settings.Default.Mainhost = Settings.Mainhost.hostname;
            Properties.Settings.Default.Mainpath = Settings.Mainhost.path;
            Properties.Settings.Default.Awayhost = Settings.Awayhost.hostname;
            Properties.Settings.Default.Awaypath = Settings.Awayhost.path;
          
        }
      
    }
}
