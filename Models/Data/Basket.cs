using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Basket
    {
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? OrderId { get; set; }
    }
}
