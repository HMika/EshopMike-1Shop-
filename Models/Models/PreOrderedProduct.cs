using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Data;

namespace Models.Models
{
    public class PreOrderedProduct
    {
        public List<Products> Products { get; set; }
        public Decimal? Total { get; set; }
    }
}
