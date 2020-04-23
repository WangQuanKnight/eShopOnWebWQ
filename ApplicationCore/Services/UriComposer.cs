using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Interface;

namespace ApplicationCore.Services
{
    public class UriComposer : IUriComposer
    {
        private readonly CatalogSettings _catalogSettings;

        public UriComposer(CatalogSettings catalogSettings)
        {
            _catalogSettings = catalogSettings;
        }
        public string ComposePictUri(string uriTemplate)
        {
            return uriTemplate.Replace("http://catalogbaseurltobereplaced", _catalogSettings.CatalogBaseUrl);
        }
    }
}
