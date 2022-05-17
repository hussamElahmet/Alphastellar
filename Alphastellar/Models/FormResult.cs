using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alphastellar.Models
{
    public class FormResult
    {
        public class BookItemResult
        {
            public decimal TotalPrice { get; set; }
            public int BusinessDays { get; set; }
            public string Currency{ get; set; }
        }
    }
}
