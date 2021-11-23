using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProductList
    {
        public List<Products> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
