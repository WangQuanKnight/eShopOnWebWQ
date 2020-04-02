using ApplicationCore.Interface;
using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class CatalogItem : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public string PictureUri { get; private set; }

        public int CatalogBrandId { get; private set; }
        public CatalogBrand CatalogBrand { get; private set; }

        public int CatalogTypeId { get; private set; }
        public CatalogType CatalogType { get; private set; }

        public CatalogItem(string name,string description,decimal price,string pictureUri,int catalogBrandId,int catalogTypeId)
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUri = pictureUri;
            CatalogTypeId = catalogBrandId;
            CatalogBrandId = catalogBrandId;
        }

        public void Update(string name,decimal price)
        {
            Guard.Against.NullOrEmpty(name, nameof(name));
            Name = name;
            Price = price;
        }
    }
}
