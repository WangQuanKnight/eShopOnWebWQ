using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.BuyerAggregate
{
    public class PaymentMethod
    {
        public string Alias { get; private set; }
        public string CardId { get; private set; }
    }
}
