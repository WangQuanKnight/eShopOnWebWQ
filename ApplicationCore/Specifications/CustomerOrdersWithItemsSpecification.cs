using ApplicationCore.Entities.OrderAggregate;
using ApplicationCore.Helpers.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class CustomerOrdersWithItemsSpecification : BaseSpecification<Order>
    {
        public CustomerOrdersWithItemsSpecification(string buyerId)
            : base(o => o.BuyerId == buyerId)
        {
            AddIncludes(query => query.Include(o => o.OrderItems).ThenInclude(i => i.CatalogItemOrdered));
        }
    }
}
