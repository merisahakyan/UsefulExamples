using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager : IManager
    {
        IDataManager datamanager;
        public Manager() :this(DependencyFactory.Resolve<IDataManager>())
        {

        }
        public Manager(IDataManager dm)
        {
            datamanager = dm;
        }
        public void DoWork()
        {
            datamanager.DoWork();
        }
    }
}
