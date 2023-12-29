using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapp.DataAccess.Repository
{
    internal interface IRepository<T> where T:class
    {
        //T - category
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
