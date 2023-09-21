

using Checkpoint_2_Nivå1;
using Checkpoint_2_Nivå2;
using Checkpoint_2_Nivå3;
using System.Diagnostics;
using System.Linq.Expressions;

AppMessages appMessages = new AppMessages();
Check check = new Check();
List<Product> productList = new List<Product>();

string category;
string productName;
string price;
int value;

//static bool QuitCheck(string St)
//{
//    if (St.ToLower().Trim() == "q")
//    {
//        return true;
//    }
//    else { return false; }
//}
//static bool NullCheck(string St)
//{
//    if (St.ToLower().Trim() == "" || St.ToLower().Trim() == null)
//    {
//        return true;
//    }
//    else { return false; }
//}
//static bool NewProduct(string St)
//{
//    if (St.ToLower().Trim() == "p")
//    {
//        return true;
//    }
//    else { return false; }
//}

addExtraProduct:
while (true)
{
    appMessages.Instructions();

tryCategoryAgain:
    Console.Write("Category: ");
    category = Console.ReadLine();
    if (check.Null(category) == true)
    {
        appMessages.NullOrEmpty();
        goto tryCategoryAgain;
    }
    if (check.Quit(category) == true)
    {
        break;
    }
    
  tryProductAgain:
    Console.Write("Product Name: ");
    productName = Console.ReadLine();
    if (check.Null(productName) == true)
    {
        appMessages.NullOrEmpty();
        goto tryProductAgain;
    }
    if (check.Quit(productName) == true)
    {
        break;
    }

  tryPriceAgain:
    Console.Write("Price: ");
    price = Console.ReadLine();
    if (check.Null(price) == true)
    {
        appMessages.NullOrEmpty();
        goto tryPriceAgain;
    }
    if (check.Quit(price) == true)
    {
        break;
    }
    if (!int.TryParse(price, out value))
    {
        appMessages.TryAgain();
        goto tryPriceAgain;
    }

    productList.Add(new Product(category, productName, value));
    appMessages.successfulAdd();
}

List<Product> sortedByPrice = productList.OrderBy(x => x.Price).ToList();

new Printing().PrintTableOfContent(sortedByPrice);

appMessages.LateAddProduct();

while (true)
{
  tryNewAgain:
    string data = Console.ReadLine();
    if (check.NewProduct(data) == true) 
    {
        goto addExtraProduct;
    }
    if (check.Null(data) == true)
    {
        appMessages.NullOrEmpty();
        goto tryNewAgain;
    }
    if (check.Quit(data) == true)
    {
        break;
    }
    if (check.Search(data) == true)
    {
        // TODO figure out how to search
        Console.WriteLine("TODO figure out how to search");
    }
}


Console.ReadLine();