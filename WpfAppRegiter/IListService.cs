using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppRegiter
{
    public interface IListService
    {
         IEnumerable<Product> GetData();

        void SaveProduct();

    }
}
