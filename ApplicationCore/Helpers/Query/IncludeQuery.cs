using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationCore.Interface;

namespace ApplicationCore.Helpers.Query
{
    public class IncludeQuery : IIncludeQuery
    {
        public Dictionary<IIncludeQuery, string> PathMap { get; } = new Dictionary<IIncludeQuery, string>();

        public IncludeVisitor Visitor { get; } = new IncludeVisitor();
        
        public HashSet<string> Paths => PathMap.Select(p => p.Value).ToHashSet();

        public IncludeQuery(Dictionary<IIncludeQuery, string> pathMap)
        {
            PathMap = pathMap;
        }
    }
}
