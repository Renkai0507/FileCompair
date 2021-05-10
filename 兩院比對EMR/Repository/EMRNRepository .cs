using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Model;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR.Repository
{
    public class EMRNRepository :BaseRepository<EMRN>, IEMRNRepository
    {
        public string conn;

        public EMRNRepository(string connstr) : base(connstr)
        {
           this.conn = connstr;
        }
      
    }
}
