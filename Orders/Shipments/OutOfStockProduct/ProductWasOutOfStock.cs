using Core.Events;
using Orders.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shipments.OutOfStockProduct
{
    public class ProductWasOutOfStock : IEvent
    {
        public Guid OrderId { get; }

        public IReadOnlyList<ProductItem> AvailableProductItems { get; }

        public DateTime AvailabilityCheckedAt { get; }


        public ProductWasOutOfStock(
            Guid orderId,
            IReadOnlyList<ProductItem> availableProductItems,
            DateTime availabilityCheckedAt
        )
        {
            OrderId = orderId;
            AvailableProductItems = availableProductItems;
            AvailabilityCheckedAt = availabilityCheckedAt;
        }
    }
}
