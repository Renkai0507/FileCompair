using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Model;

namespace 兩院比對EMR.Repository
{
    public interface ILinenote : IBaseRepository<EMRN>
    {
        void insert(Linenote linenote);
    }
}
