using OrderCoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCoffeeApp.Models
{
    public class Order
    {
        public List<DrinkItem> Items { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public string PaymentStatus { get; set; }

        // Thuộc tính định dạng thời gian
        public string FormattedTime => $"Đặt lúc: {CreatedTime:HH:mm dd/MM/yyyy}";

        // Thuộc tính định dạng tổng tiền
        public string FormattedTotalAmount => $"Tổng tiền: {TotalAmount:N0}đ";
    }
}
