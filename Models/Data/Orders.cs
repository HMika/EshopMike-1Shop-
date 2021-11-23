using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Orders
    {
        public Orders()
        {
            ProductsOrders = new HashSet<ProductsOrders>();
        }

        public int Id { get; set; }
        public string NumberOfOrder { get; set; }
        public int? IdProduct { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Psc { get; set; }
        public string Email { get; set; }
        public int? ApartmentNumber { get; set; }

        public virtual ICollection<ProductsOrders> ProductsOrders { get; set; }
    }
}
