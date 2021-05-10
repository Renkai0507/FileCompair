using Autofac;
using System;
using System.Windows.Forms;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR
{
    static class Program
    {
        public static IContainer Container;
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Container = Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(Container.Resolve<IRepositoryWrapper>()));
        }
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<RepositoryWrapper>().As<IRepositoryWrapper>();
            
            return builder.Build();
        }
        
    }
}
