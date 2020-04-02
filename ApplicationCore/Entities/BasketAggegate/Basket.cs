using ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Entities.BasketAggegate
{
    public class Basket : BaseEntity, IAggregateRoot
    {
        public string BuyerId { get; private set; }
        private readonly List<BasketItem> _basketItems = new List<BasketItem>();
        public IReadOnlyCollection<BasketItem> BasketItems => _basketItems.AsReadOnly();

        public Basket(string buyerId)
        {
            BuyerId = buyerId;
        }

        public void AddItem(decimal unitPrice, int quantity,int catalogItemId)
        {
            if(!_basketItems.Any(b => b.CatalogItemId == catalogItemId)){
                _basketItems.Add(new BasketItem(unitPrice, quantity, catalogItemId));
                return;
            }

            var existItems = _basketItems.FirstOrDefault(b => b.CatalogItemId == catalogItemId);
            existItems.AddQuntity(quantity);
        }

        public void RemoveEmptyItems()
        {
            _basketItems.RemoveAll(b => b.Quantity == 0);
        }

        public void SetNewBuyerId(string buyerId)
        {
            BuyerId = buyerId;
        }
    }
}
