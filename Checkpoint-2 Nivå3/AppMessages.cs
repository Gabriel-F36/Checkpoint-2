﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2_Nivå2
{
    internal class AppMessages
    {
        public void Instructions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Add Title, Product name and Price | Enter: 'q' to quit");
            Console.ResetColor();
        }
        public void successfulAdd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully");
            Console.ResetColor();
        }
        public void TryAgain()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("It wasn't a valid number, try again");
            Console.ResetColor();
            
        }
        public void LateAddProduct() 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("To enter a new product, enter 'P' | To search for a product, enter 'S' | To quit, enter 'Q'");
            Console.ResetColor();
        }
        public void NullOrEmpty() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Value can't be null or empty");
            Console.ResetColor();
        }
    }
}
