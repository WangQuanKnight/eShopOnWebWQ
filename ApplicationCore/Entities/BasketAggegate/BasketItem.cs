using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.BasketAggegate
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }

        public int CatalogItemId { get; private set; }

        public int BasketId { get; private set; }

        public BasketItem(decimal unitPrice,int quantity,int catalogItemId)
        {
            CatalogItemId = catalogItemId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public void AddQuntity(int quantity)
        {
            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

    }
}
