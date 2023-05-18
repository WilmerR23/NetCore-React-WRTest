using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Models
{
    public class QueryResponseObject<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int Count { get; set; }
        public QueryResponseObject(int count ,IEnumerable<T> items)
        {
            Count = count;
            Items = items;
        }
    }
}
