using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.OrderAggregate
{
    /// <summary>
    /// 表示一个订购的产品的快照。一旦条目详细信息发生变化，完整订单的 item 详细信息不应该发生变化。
    /// </summary>
    public class CatalogItemOrdered
    {
        public int CatalogItemId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUri { get; private set; }

        private CatalogItemOrdered()
        {
            //required by EF
        }

        public CatalogItemOrdered(int catalogItemId,string productName,string pictureUri)
        {
            Guard.Against.OutOfRange(catalogItemId, nameof(catalogItemId), 0, int.MaxValue);
            Guard.Against.NullOrEmpty(productName, nameof(productName));
            Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));
        }
    }
}
