using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interface
{
    public interface IBasketService
    {
        Task<int> GetBasketItemCountAsync(string userName);
    }
}
