using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 兩院比對EMR
{
    public partial class AutoCount : Form
    {
        public AutoCount(BackgroundWorker backgroundWorker)
        {
            InitializeComponent();
            this.bkwcnt = backgroundWorker;
            bkwcnt.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            bkwcnt.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();//执行完之后，直接关闭页面
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {           
            lb_cnt.Text = e.UserState.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bkwcnt.WorkerSupportsCancellation = true;
            this.bkwcnt.CancelAsync();
            this.button1.Enabled = false;
            this.Close();            
        }
    }
}
