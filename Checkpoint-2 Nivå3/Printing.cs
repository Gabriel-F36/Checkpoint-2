using Checkpoint_2_Nivå1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2_Nivå2
{
    internal class Printing
    {
        public Printing() { Console.WriteLine("Category".PadRight(10) + "ProductName".PadRight(14) + "Price"); }

        public void PrintTableOfContent(List<Product> productList)
        {
            int sum = 0;
            foreach (Product p in productList)
            {
                Console.WriteLine(p.Category.PadRight(10) + p.ProductName.PadRight(14) + p.Price);
                sum += p.Price;
            }
            Console.WriteLine();
            Console.WriteLine("".PadRight(10) + "Total Price:".PadRight(14) + sum);
        }
    }
}
