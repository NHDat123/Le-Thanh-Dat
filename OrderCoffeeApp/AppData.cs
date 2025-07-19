using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OrderCoffeeApp.Models
{
    public static class AppData
    {
        public static ObservableCollection<Order> AllOrders { get; set; } = new ObservableCollection<Order>();
    }
}
