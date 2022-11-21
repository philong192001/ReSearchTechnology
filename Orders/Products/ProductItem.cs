using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Products
{
    public class ProductItem
    {
        public Guid ProductId { get; }

        public int Quantity { get; }

        public ProductItem(Guid productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
