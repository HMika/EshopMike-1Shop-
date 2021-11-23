using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Products
    {
        public Products()
        {
            ProductsCategory = new HashSet<ProductsCategory>();
            ProductsOrders = new HashSet<ProductsOrders>();
        }

        public int Id { get; set; }
        public string NameOfProduct { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Discount { get; set; }
        public int? Dph { get; set; }
        public string PhotoPath { get; set; }
        public int? Rate { get; set; }
        public string Size { get; set; }
        public string Vendor { get; set; }
        public int? Quantity { get; set; }

        public virtual ICollection<ProductsCategory> ProductsCategory { get; set; }
        public virtual ICollection<ProductsOrders> ProductsOrders { get; set; }
    }
}
