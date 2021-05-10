using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 兩院比對EMR.Helper;
using 兩院比對EMR.Model;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR.Controller
{
    class CompareController 
    {
        static string LoadStatus;
        List<DateTime> DateRange;
        public List<Compair_DIFF> difflist;       
        IRepositoryWrapper Repository;
        public BindingSource BindingSourceEMRNA;
        public BindingSource BindingSourceEMRNB;
        public BindingSource Difftable;
    

        public CompareController(IRepositoryWrapper repository)
        {
            Repository = repository;
            difflist = new List<Compair_DIFF>();
        }
        public void Copyfile(List<Compair_DIFF> difffile)
        {        
            var filepaths = new List<string>();
            difffile.ForEach(X=> 
            {
                if (X.Note== "次要主機無此檔案")
                {
                    filepaths.Add(X.FilePath+@"\"+X.Filename);
                }
            });
            CopytoAwaypath(filepaths);
        }

        private void CopytoAwaypath(List<string> filepaths)
        {
            filepaths.ForEach(X=> 
            {
                string changhost = X.Replace(Settings.Mainhost.hostname,Settings.Awayhost.hostname);
                string awaypath = changhost.Replace(Settings.Mainhost.path,Settings.Awayhost.path);
                if (!IOhelper.FileExists(awaypath))
                {
                    IOhelper.FileCopy(X,awaypath);
                }
            });
        }

        public string ResulttoCSV(List<Compair_DIFF> diff)
        {
            string today = DateTime.Now.ToString("yyyyMMdd");
            string filename = @"\\zckemrb\C$\cch\log" + @"\"+today+".csv";
            
            FileStream fs =new FileStream(filename,FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            sw.WriteLine("檔案名稱,路徑,主機,備註,日期");
            diff.ForEach(X=> 
            {
                sw.WriteLine(X.Filename+","+X.FilePath+","+X.Hostname+","+X.Note+","+today);
            });
            sw.Close();
            fs.Close();
            return today+".csv";
        }
        
       
        public List<TmpSave> HostToDatePath(Hostlocate locate)
        {
            string hostpath = PublicMethod.pathhead(locate);
            List<TmpSave> tmpTable = new List<TmpSave>();
            DateRange.ForEach((x) =>
            {
                string fullpath = hostpath+ PublicMethod.pathdate(x);
                if (Directory.Exists(fullpath))
                {
                    tmpTable.AddRange(FileToTmptable(locate.hostname, fullpath, x));
                }
            });
            return tmpTable;
        }
     
        public List<HostEMRN> Dbcheckdata(List<DateTime> dateRange)
        {
            DateRange = dateRange;
            List<HostEMRN> hosts = new List<HostEMRN>();
            hosts.Add(new HostEMRN
            {
                hostlocate=Settings.Awayhost,
                EMRNs= FindDBdata("A")
            });
            hosts.Add(new HostEMRN
            {
                hostlocate = Settings.Mainhost,
                EMRNs = FindDBdata("B")
            });
            return hosts;
        }

        public void CheckFile(EMRN emrn, Hostlocate locate)
        {
            DateTime transdate;
            string hostpath;
            string Plaintext;
            string Signature;
            string TimeStamp;           
            
                transdate= DateTime.ParseExact(emrn.TransNo.Substring(1,8),"yyyyMMdd",null) ;
                
                hostpath = PublicMethod.pathhead(locate) + PublicMethod.pathdate(transdate);
                
                Plaintext =@"\"+ emrn.TransNo+"_PlainText.dat";
                Signature =@"\"+ emrn.TransNo+"_Signature.dat";
                TimeStamp =@"\"+ emrn.TransNo+"_TimeStamp.dat";

                AddDiffDBFile(emrn, locate, Plaintext);
                AddDiffDBFile(emrn, locate, Signature);
                AddDiffDBFile(emrn, locate, TimeStamp);
            
         
        }
       public void AddDiffDBFile(EMRN emrn, Hostlocate host,string type)
       {
            DateTime transdate = DateTime.ParseExact(emrn.TransNo.Substring(1, 8), "yyyyMMdd", null);
            string hostpath = PublicMethod.pathhead(host) + PublicMethod.pathdate(transdate);
            string Filename = @"\"+ type;
            Compair_DIFF tmpdiff = new Compair_DIFF();
            if (!IOhelper.FileExists(hostpath + Filename))
            {
                tmpdiff.Datetime = transdate;
                tmpdiff.Filename = Filename;
                tmpdiff.FilePath = hostpath + Filename;
                tmpdiff.Hostname = host.hostname;
                tmpdiff.Note = "比對TransNo缺少檔案";
                difflist.Add(tmpdiff);
            }        
        }
        

        public List<EMRN> FindDBdata(string zone)
        {
            List<int> Dateint = DateToEMRN();
            List<EMRN> result = new List<EMRN>();
            foreach (var emrdata in Dateint)
            {
                if (zone=="A")
                {
                    var emrbs = Repository.EMRNA.GetAllList(emrdata);
                    result.AddRange(emrbs);
                }
                else if (zone=="B")
                {
                    var emras = Repository.EMRNB.GetAllList(emrdata);
                    result.AddRange(emras);
                }               
            }
            return result;
        }
        public List<int> DateToEMRN()
        {            
            List<int> Dateint = new List<int>();
            foreach (var x in DateRange)
            {
                string year = (x.Year - 1911).ToString();
                string month = x.Month.ToString("00");
                string day = x.Day.ToString("00");
                Dateint.Add(int.Parse(year + month + day));
            }           
            return Dateint;
        }

       
        public List<TmpSave> FileToTmptable(string hostname,string filepath,DateTime savedate)
        {            
                List<TmpSave> tmpTable = new List<TmpSave>();
                IOhelper.getallfilename(filepath).ForEach((S) =>
                {
                    tmpTable.Add(new TmpSave()
                    {
                        SaveDate = savedate,
                        Filename = S,
                        Filepath = filepath,
                        Hostname = hostname,
                        Note = ""
                    });
                });
                return tmpTable;
         }
       

    }
}
