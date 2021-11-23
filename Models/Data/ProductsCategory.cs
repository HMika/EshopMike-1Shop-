using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class ProductsCategory
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdCategory { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Products IdProductNavigation { get; set; }
    }
}
