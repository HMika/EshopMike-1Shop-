using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CartInformation
    {
        public List<Products> Products { get; set; } = new List<Products>();
        public Orders Orders { get; set; }
        public MyBasket MyBasket { get; set; }
    }
}
