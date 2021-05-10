using System;

using System.Data;
using Dapper;
using System.Data.SqlClient;

using 兩院比對EMR.Model;


namespace 兩院比對EMR.Repository
{
    public class LinenoteRepository :BaseRepository<EMRN>, ILinenote
    {
        public string conn;

        public LinenoteRepository(string connstr) : base(connstr)
        {
           this.conn = connstr;
        }

        public void insert(Linenote linenote)
        {
            IDbConnection db = new SqlConnection(conn);
            if (db.State == ConnectionState.Closed)
                db.Open();
            string sqlstring = "insert into LineNotifyMsg (GroupID,Msg,InsUser,PlanSendTime) values "+
                               "(@GroupID,@Msg,@InsUser,@PlanSendTime)";
            db.Execute(sqlstring,linenote);
        }
    }
}
