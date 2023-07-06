using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppRegiter
{
    public class ListService : IListService
    {
        public IEnumerable<Product> GetData()
        {
			List<Product> products = new List<Product>() {
				new Product() {Id=1, Brand = "Apple",Name = "Iphone" },
				new Product() {Id=2, Brand = "Apple",Name = "IPad" }
			};
			return products.AsEnumerable();
		}

        public void SaveProduct()
        {
            throw new NotImplementedException();
        }
    }
}
