using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.BasketAggegate;

namespace ApplicationCore.Specifications
{
    public class BasketWithItemsSpecification : BaseSpecification<Basket>
    {
        public BasketWithItemsSpecification(int basketId)
            :base(b => b.Id == basketId)
        {
            AddInclude(b => b.BasketItems);
        }

        public BasketWithItemsSpecification(string buyerId)
            :base(b => b.BuyerId == buyerId)
        {
            AddInclude(b => b.BasketItems);
        }
    }
}
