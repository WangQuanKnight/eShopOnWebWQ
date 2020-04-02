using ApplicationCore.Helpers.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace UnitTests.ApplicationCore.Helpers.Query.IncludeVisitorTests
{
    public class Visitor
    {
        [Fact]  
        public void Should_SetPath_IfPassedExpressionWithSimpleType()
        {
            var visitor = new IncludeVisitor();
            Expression<Func<Book, string>> expression = (book) => book.Author.Address.Street;
            visitor.Visit(expression);

            var expectedPath = $"{nameof(Book.Author)}.{nameof(Person.Address)}.{nameof(Address.Street)}";
            Assert.Equal(visitor.Path, expectedPath);
        }
    }
}
