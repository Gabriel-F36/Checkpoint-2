

using Checkpoint_2_Nivå1;
using System.Diagnostics;
using System.Linq.Expressions;

//Product product = new Product();
List<Product> productList = new List<Product>();


string cat;
string prod;
string pri;
int value;

while (true)
{
    Console.Write("Category: ");
    cat = Console.ReadLine();
    if (cat.ToLower().Trim() == "q")
    {
        break;
    }
    
    Console.Write("Product Name: ");
    prod = Console.ReadLine();
    if (prod.ToLower().Trim() == "q")
    {
        break;
    }

    tryPriceAgain:
    Console.Write("Price: ");
    pri = Console.ReadLine();
    if (pri.ToLower().Trim() == "q")
    {
        break;
    }
    if (!int.TryParse(pri, out value))
    {
        Console.WriteLine("It wasn't a valid number, try again");
        goto tryPriceAgain;
    }
        
    productList.Add(new Product(cat, prod, value));
    Console.WriteLine("Product added");
}

// Printing the productlist in specific format

Console.WriteLine("Category".PadRight(10) + "ProductName".PadRight(14) + "Price");
foreach (Product p in productList)
{
    Console.WriteLine(p.Category.PadRight(10) + p.ProductName.PadRight(14) + p.Price);
}


Console.ReadLine();

//version 1.1