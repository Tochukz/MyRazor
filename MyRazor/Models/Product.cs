using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazor.Models
{
    public class Product
    {
        public int ProductID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public string Category { set; get; }
    }
}
