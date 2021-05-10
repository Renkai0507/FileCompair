using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 兩院比對EMR.Model;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR.Repository
{
    public interface IRepositoryWrapper
    {
        IEMRNRepository EMRNA { get; }
        IEMRNRepository EMRNB { get; }
        ILinenote Linenote { get; }
    }
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IEMRNRepository _EMRNA { get; }
        private IEMRNRepository _EMRNB { get; }
        private ILinenote _Linenote { get; }
        public string LineContext { get; }
        public string EMRNBContext { get; }
        public string EMRNAContext { get; }

        public RepositoryWrapper()
        {
            string connB = "data source=zckemrb;initial catalog=UnimaxEMR;persist security info=True;user id=EMR;password=EMR;MultipleActiveResultSets=True;App=EntityFramework";
            string connA = "data source=zptemra;initial catalog=UnimaxEMR;persist security info=True;user id=EMR;password=EMR;MultipleActiveResultSets=True;App=EntityFramework";
            string linecon= "data source=ZCKSQLP03;initial catalog=MasBasic;persist security info=True;user id=sysuser;password=sysuser;MultipleActiveResultSets=True;";
            EMRNBContext = connB;
            EMRNAContext = connA;
            LineContext = linecon;
        }
      
        public IEMRNRepository EMRNA => _EMRNA ?? new EMRNRepository(EMRNAContext);
        public IEMRNRepository EMRNB => _EMRNB ?? new EMRNRepository(EMRNBContext);
        public ILinenote Linenote => _Linenote ?? new LinenoteRepository(LineContext);

    }
}
