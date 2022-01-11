using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"/Users/miinasooster/samples/shoppingist";
            string fileName = @"/shoppinglist.txt";


            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;




            while (loopActive)

            {
                Console.WriteLine("Would you like to add item to the shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string usershoppinglist = Console.ReadLine();
                    shoppinglist.Add(usershoppinglist);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }



            Console.Clear();
            foreach (string item in shoppinglist)
            {
                Console.WriteLine($"Your item: {item}");
            }



            File.WriteAllLines($"{fileLocation}{fileName}", shoppinglist);
        }
    }
}