using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Models
{
    public class Response<TDto>
    {
        public IEnumerable<TDto> Items { get; set; }
        public int Count { get; set; }
        public Response(int count, IEnumerable<TDto> items)
        {
            Count = count;
            Items = items;
        }
    }
}
