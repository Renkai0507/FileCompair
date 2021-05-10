using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using Dapper;


namespace 兩院比對EMR.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class
    {
        public string conn;
        public BaseRepository(string connstr)
        {
            conn = connstr;
        }
        public int Count(int numdate)
        {

            return GetAllList(numdate).Count();
        }


        public List<T> GetAllList(int numdate)
        {
            IDbConnection db = new SqlConnection(conn);
            if (db.State == ConnectionState.Closed)
                db.Open();
            var sqlstr = db.Query<T>(@"Select GenDate,SeqNo,FormNo,Clerk,SysDate,SysTime,Finished,TransNo,Zone " +
                            "FROM EMRN WHERE Finished <> 'X' and TransNo <> '' and GenDate= @date",new {date= numdate },
                            commandType: CommandType.Text);
            return sqlstr.ToList();
        }

   
    }
}
