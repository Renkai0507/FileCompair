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
    public partial class ProgressBar : Form
    {
        int totalfile;
        public ProgressBar(BackgroundWorker backgroundWorker,int total)
        {
            InitializeComponent();
            this.bgw = backgroundWorker;
            bgw.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            lb_total.Text = total.ToString();
            totalfile = total;
        }
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();//执行完之后，直接关闭页面
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            lb_cnt.Text = (e.ProgressPercentage*totalfile/100).ToString();
            lb_filename.Text = e.UserState.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgw.WorkerSupportsCancellation = true;
            this.bgw.CancelAsync();
            this.button1.Enabled = false;
            this.Close();
        }
    }
}
