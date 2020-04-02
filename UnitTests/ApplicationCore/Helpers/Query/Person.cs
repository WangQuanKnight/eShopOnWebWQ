using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.ApplicationCore.Helpers.Query
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Book FavouriteBook { get; set; }
        public List<Person> Friends { get; set; }
        public Address Address { get; set; }
        public string GetQuote()
        {
            return string.Empty;
        }
    }
}
