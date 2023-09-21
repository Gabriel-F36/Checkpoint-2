

using Checkpoint_2_Nivå1;
using Checkpoint_2_Nivå2;
using System.Diagnostics;
using System.Linq.Expressions;

AppMessages appMessages = new AppMessages();
appMessages.Instructions();
List<Product> productList = new List<Product>();

string category;
string productName;
string price;
int value;

while (true)
{
    Console.Write("Category: ");
    category = Console.ReadLine();
    if (category.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Product Name: ");
    productName = Console.ReadLine();
    if (productName.ToLower().Trim() == "q")
    {
        break;
    }

tryPriceAgain:
    Console.Write("Price: ");
    price = Console.ReadLine();
    if (price.ToLower().Trim() == "q")
    {
        break;
    }
    if (!int.TryParse(price, out value))
    {
        Console.WriteLine("It wasn't a valid number, try again");
        goto tryPriceAgain;
    }

    productList.Add(new Product(category, productName, value));
    Console.WriteLine("Product added");
}

List<Product> sortedByPrice = productList.OrderBy(x => x.Price).ToList();

new Printing().PrintTableOfContent(sortedByPrice);


Console.ReadLine();