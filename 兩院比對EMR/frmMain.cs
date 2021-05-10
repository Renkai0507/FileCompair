using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Helper;
using System.Windows.Forms;
using 兩院比對EMR.Repository;
using 兩院比對EMR.Model;

namespace 兩院比對EMR
{
    public partial class frmMain : Form
    {
        Form frm;
        IRepositoryWrapper Repository;
        
        public frmMain(IRepositoryWrapper repository)
        {            
            InitializeComponent();
            LoaddefautSettings();
            Repository = repository;
            ManagerPage.Click += delegate
            {
                frm = new frmManager(Repository); newPage(frm);
            };
           
            ComparPage.Click += delegate
            {
                frm = new frmCompare(Repository); newPage(frm);
            };
            ComparPage.PerformClick();
        }

        private void newPage(Form form)
        {
            bool opened=false;
            foreach (Form son in this.MdiChildren)
            {
                if (form.Name==son.Name)
                {
                    son.Activate();
                    son.WindowState = FormWindowState.Maximized;
                    form.Dispose();
                    opened = true;
                }
            }
            if (!opened)
            {
                form.MdiParent = this;
                form.Show();
            }            
        }
        
        public void LoaddefautSettings()
        {
            Settings.Mainhost.hostname = Properties.Settings.Default.Mainhost;
            Settings.Mainhost.path = Properties.Settings.Default.Mainpath;
            Settings.Awayhost.hostname = Properties.Settings.Default.Awayhost;
            Settings.Awayhost.path = Properties.Settings.Default.Awaypath;
            Settings.Autorun = Properties.Settings.Default.Autorun;
        }

        
    }
}
