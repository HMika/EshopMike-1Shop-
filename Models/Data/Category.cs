using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Category
    {
        public Category()
        {
            ProductsCategory = new HashSet<ProductsCategory>();
        }

        public int Id { get; set; }
        public string NameOfcategory { get; set; }

        public virtual ICollection<ProductsCategory> ProductsCategory { get; set; }
    }
}
