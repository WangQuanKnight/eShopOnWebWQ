using ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Helpers.Query
{
    public class IncludeAggregator<TEntity>
    {
        public IncludeQuery<TEntity,TProperty> Include<TProperty>(Expression<Func<TEntity,TProperty>> selector)
        {
            IncludeVisitor visitor = new IncludeVisitor();
            visitor.Visit(selector);

            Dictionary<IIncludeQuery, string> pathMap = new Dictionary<IIncludeQuery, string>();
            IncludeQuery<TEntity,TProperty> query = new IncludeQuery<TEntity,TProperty>(pathMap);

            if (!string.IsNullOrEmpty(visitor.Path))
            {
                pathMap[query] = visitor.Path;
            }

            return query;
        }
    }
}
