using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class OrderedBasket
    {
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int Id { get; set; }
    }
}
