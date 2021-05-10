using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Model;

namespace 兩院比對EMR.Repository
{
    public interface IBaseRepository<T> where T :class
    {
        List<T> GetAllList(int numdate);       
        int Count(int numdate);
    }
}
