using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class ProductsOrders
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }

        public virtual Orders IdOrderNavigation { get; set; }
        public virtual Products IdProductNavigation { get; set; }
    }
}
