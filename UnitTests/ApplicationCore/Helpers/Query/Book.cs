using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.ApplicationCore.Helpers.Query
{
    public class Book
    {
        public string Title { get; set; }
        public DateTime PublishingDate { get; set; }
        public Person Author { get; set; }

        public int GetNumberOfSales()
        {
            return 0;
        }
    }
}
