using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2_Nivå1
{
    internal class Product
    {
        public Product()
        {
        }

        public Product(string category, string productName, int price)
        {
            Category = category;
            ProductName = productName;
            Price = price;
        }

        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
// just checking with github
