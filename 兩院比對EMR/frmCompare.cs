using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 兩院比對EMR.Controller;
using 兩院比對EMR.Helper;
using 兩院比對EMR.Model;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR
{
    public partial class frmCompare : Form
    {
        IRepositoryWrapper Repository;
        CompareController controller;
        CompairFile compairFile;
        List<Compair_DIFF> diffs;
        List<TmpSave> mainfiles;
        List<HostEMRN> HostEMRNs;
        public frmCompare(IRepositoryWrapper repository)
        {
            InitializeComponent();
            Init();
            Repository = repository;
            controller = new CompareController(Repository);
            diffs = new List<Compair_DIFF>();
            btnCompar.Click += delegate{  compare(); bgw.DoWork -= bgw_DoWork; };
            btn_data.Click += delegate { DbCheckExist(); bgw.DoWork -= bgw_checkDB; };
            btn_excel.Click += delegate { ToCSV(); };
            btn_exit.Click += delegate { System.Environment.Exit(0); };
            btn_copy.Click += delegate { copyfile(); };
            btn_clear.Click += delegate { DataClear(); };
            dtDate1.Value = DateTime.Today.AddDays(-1);
            dtDate2.Value = DateTime.Today.AddDays(-1);

        }

        private void DataClear()
        {
            compair_DIFFBindingSource.DataSource = null;
            diffs.Clear();
            if (mainfiles!=null)
            {
                tmpSaveBindingSource.DataSource = null;
                mainfiles.Clear();
            }
            if (HostEMRNs!=null)
            {
                eMRNBindingSource.DataSource = null;
                eMRNBindingSource2.DataSource = null;
                HostEMRNs.Clear();
            }
        }

        public void Init()
        {
            TB_Mainhost.Text = Settings.Mainhost.hostname;
            TB_Awayhost.Text = Settings.Awayhost.hostname;

        }
        public void ToCSV()
        {
           string filename= controller.ResulttoCSV(diffs);
           string complete = "**" + DateTime.Today.ToString("yyyy/MM/dd") + "**%0D%0A" +
                          "EMR比對完成！%0D%0A";
            if (diffs.Count>0)
            {
                int datadiff = diffs.Where(X => X.Note == "比對TransNo缺少檔案").ToList().Count();
                int filediff = diffs.Where(X => X.Note == "次要主機無此檔案").ToList().Count();
                string erromsg = "比對異常 %0D%0A資料庫比對異常數量"+datadiff.ToString()+"$0D%0A"+
                                 "實體檔案異常數量"+filediff.ToString() + "%0D%0A" +
                                @"詳細請查看 \\zckemrb\C$\cch\log\" + filename;
                complete = complete + erromsg;
            }
            Repository.Linenote.insert(new Linenote(complete));
        }
        public void copyfile()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("確定要複製?","複製提醒",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog==DialogResult.Yes)
            {
                controller.Copyfile(diffs);
            }
        }
        public void compare()
        {
            List<DateTime> Allday = new List<DateTime>();
            for (var dt = dtDate1.Value.Date; dt <= dtDate2.Value.Date; dt = dt.AddDays(1))
            {
                Allday.Add(dt);
            }
            compairFile = new CompairFile();
            mainfiles = compairFile.GetMainFile(Allday);
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork -= bgw_checkDB;
            bgw.DoWork += bgw_DoWork;
            bgw.RunWorkerAsync();
            ProgressBar form = new ProgressBar(bgw, mainfiles.Count) ;                        
            form.ShowDialog(this);
            form.Close();
            diffs.AddRange( compairFile.compair_DIFFs);
            compair_DIFFBindingSource.DataSource = null;
            compair_DIFFBindingSource.DataSource = diffs;
            tmpSaveBindingSource.DataSource = mainfiles;
        }
        private void bgw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            
            int workcnt = 1;
            foreach (var X in mainfiles)
            {
                compairFile.FindAwayfile(X);
                worker.ReportProgress(workcnt*100/mainfiles.Count,X.Filename);
                workcnt += 1;
                if (worker.CancellationPending)
                {
                    e.Cancel=true;
                    break;
                }
            };
        }

        private void CompleteWork(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //MessageBox.Show(e.Error.Message);
            } else if (e.Cancelled)
            {
                bgw.CancelAsync();
            }
        }
        public void DbCheckExist()
        {
            List<DateTime> Allday = new List<DateTime>();
            for (var dt = dtDate1.Value.Date; dt <= dtDate2.Value.Date; dt = dt.AddDays(1))
            {
                Allday.Add(dt);
            }
            controller = new CompareController(Repository);

            HostEMRNs = controller.Dbcheckdata(Allday);
            int total = 0;
            HostEMRNs.ForEach(X => { total += X.EMRNs.Count; });
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork -= bgw_DoWork;            
            bgw.DoWork += bgw_checkDB;
            bgw.RunWorkerAsync();
            ProgressBar form = new ProgressBar(bgw, total);
            form.ShowDialog(this);
            form.Close();
            diffs.AddRange(controller.difflist);
            compair_DIFFBindingSource.ResetBindings(true);
            compair_DIFFBindingSource.DataSource = diffs;
            eMRNBindingSource.DataSource = HostEMRNs[0].EMRNs;
            eMRNBindingSource2.DataSource = HostEMRNs[1].EMRNs;
        }
        private void bgw_checkDB(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            int total = 0;
            HostEMRNs.ForEach(X => { total += X.EMRNs.Count; });
            int workcnt = 1;
            foreach (var X in HostEMRNs)
            {
                foreach (var Y in X.EMRNs)
                {
                    controller.CheckFile(Y,X.hostlocate);
                    worker.ReportProgress(workcnt * 100 / total, Y.TransNo);
                    workcnt += 1;
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                };                
            };
        }
        public void AutoMove()
        {
            btnCompar.PerformClick();
            Task.Delay(2000);
            btn_data.PerformClick();
            Task.Delay(2000);
            btn_excel.PerformClick();
            Task.Delay(2000);
            btn_exit.PerformClick();
        }

        private void frmCompare_Shown(object sender, EventArgs e)
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += AutocountDown;
            bgw.RunWorkerAsync();
            AutoCount AC = new AutoCount(bgw);
            AC.ShowDialog(this);
            AC.Close();
            if (!bgw.CancellationPending)
            {
                AutoMove();
            } 
            
        }
        public void AutocountDown(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                worker.ReportProgress(i/10,i.ToString());
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
            
        }
        private void CompleteAuto(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
            }
            else if (e.Cancelled)
            {
                bgw.CancelAsync();
            }
            else
                AutoMove();
        }
    }
}
