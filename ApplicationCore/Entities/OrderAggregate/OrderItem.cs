using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public CatalogItemOrdered CatalogItemOrdered { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }

        private OrderItem()
        {
            //required by EF
        }

        public OrderItem(CatalogItemOrdered catalogItemOrdered,decimal unitPrice,int quantity)
        {
            CatalogItemOrdered = catalogItemOrdered;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
