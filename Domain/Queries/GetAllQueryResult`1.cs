using System;
using System.Collections.Generic;

namespace Domain.Queries
{
    public class GetAllQueryResult<T>
    {
        public IEnumerable<T> Payload { get; set; }
    }
}
