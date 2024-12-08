using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDictionary.Core.Entities
{
    public class ReturnModel<TData>
    {
        public TData Data { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public bool Success { get; set; }
    }
}
