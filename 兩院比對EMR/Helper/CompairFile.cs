using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Model;

namespace 兩院比對EMR.Helper
{
    class CompairFile
    {
        public List<TmpSave> Maintmp;
        public List<Compair_DIFF> compair_DIFFs;
        List<DateTime> DateRange;
        public int allfilescount=0;
        
        public CompairFile()
        {
            compair_DIFFs = new List<Compair_DIFF>();            
        }
        public List<TmpSave> GetMainFile(List<DateTime> dateRange)
        {
            DateRange = dateRange;
            return  HostToDatePath(Settings.Mainhost);            
        }
        public void contrastFile(List<DateTime> dateRange)
        {
            List<TmpSave> Awaytmp = HostToDatePath(Settings.Awayhost);
          
        }
        public List<TmpSave> HostToDatePath(Hostlocate locate)
        {
            string hostpath = PublicMethod.pathhead(locate);
            List<TmpSave> tmpTable = new List<TmpSave>();
            
            DateRange.ForEach((x) =>
            {
                string fullpath = hostpath + PublicMethod.pathdate(x);
                if (Directory.Exists(fullpath))
                {
                    //allfilescount += IOhelper.Getfilecount(fullpath);
                    tmpTable.AddRange(FileToTmptable(locate.hostname, fullpath, x));
                }
            });
            return tmpTable;
        }
        public List<TmpSave> FileToTmptable(string hostname, string filepath, DateTime savedate)
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

        internal void FindAwayfile(TmpSave x)
        {
            string changhost = x.Filepath.Replace(Settings.Mainhost.hostname, Settings.Awayhost.hostname).Replace(":","$");
            
            string awaypath = changhost.Replace(Settings.Mainhost.path, Settings.Awayhost.path);
            if (!IOhelper.FileExists(awaypath+@"\"+x.Filename))
            {
                compair_DIFFs.Add(new Compair_DIFF
                {
                    Datetime = x.SaveDate,
                    Filename = x.Filename,
                    FilePath = x.Filepath,
                    Hostname = x.Hostname,
                    Note = "次要主機無此檔案"
                });
            }
        }
    }
}
