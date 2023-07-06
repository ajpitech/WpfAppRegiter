using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppRegiter
{
    public class MainWindowViewModel
    {
        ListService listService;
        public IEnumerable<Product> ProductsList { get; set; }

        public MainWindowViewModel()
        {
            ProductsList = listService.GetData();
        }

        void Save()
        {
        }
    }
}
