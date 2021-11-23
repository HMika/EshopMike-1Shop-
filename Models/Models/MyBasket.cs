using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    /// <summary>
    /// Kosik tabulka
    /// </summary>
    public class MyBasket
    {
        public int TotalPrice { get; set; }
        public List<Products> ProductList { get; set; }
        public List<int> Quantity { get; set; }
    }
}
