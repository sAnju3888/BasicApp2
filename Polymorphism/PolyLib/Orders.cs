using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyLib
{
    public class Orders
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        
        public virtual string AddtoCart(int prodid)
        {
            productID = prodid;
            return $"Product added to cart with productID={productID}"
        }

    }
}
