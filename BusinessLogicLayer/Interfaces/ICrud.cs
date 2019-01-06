using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICrud<T>
    {
        //int CreateOrUpdate(T model);
        //bool Delete(int id);
        IEnumerable<T> Get(int? id, string searchText);
    }
}
