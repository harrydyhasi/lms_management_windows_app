using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Cart
    {
        public string CartId { get; set; }
        public string TotalPrice { get; set; }

        public Cart()
        {

        }

        public Cart(string cartId, string totalPrice)
        {
            CartId = cartId;
            TotalPrice = totalPrice;
        }

        public Cart(DataRow row)
        {
            CartId = row["cart_owner"].ToString();
            TotalPrice = row["total_price"].ToString();
        }
    }
}
