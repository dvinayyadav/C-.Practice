using System;
using System.Collections.Generic;
using Pratice;

namespace Practice
{
    class ArrayPractice
    {
        public void showArray()
        {
            string[] initialFruits = { "Apple", "Orange", "Banana" };
            List<string> list = new List<string>(initialFruits);

            while (true)
            {
                DisplayFun.display();
                Console.WriteLine("Please select an option to perform:");
                int opt = Convert.ToInt32(UserInput.userInput());

                if (opt == 1) 
                {
                    Console.WriteLine("Fruits in the array:");
                    if (list.Count == 0)
                    {
                        Console.WriteLine("The list is empty.");
                    }
                    else
                    {
                        foreach (string fruit in list)
                        {
                            Console.WriteLine(fruit);
                        }
                    }
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Please enter the fruit name to add:");
                    string newFruit = UserInput.userInput();
                    if (CheckingPresentOrNot.isPresent(list, newFruit))
                    {
                            list.Add(newFruit);
                            Console.WriteLine($" {newFruit} has been added to the list.");
                    }
                    else
                    {
                        Console.WriteLine($"{newFruit}  is already present in the list: ");
                    }
                }
                else if (opt == 3)
                {
                    Console.WriteLine("Enter the fruit name to find:");
                    string targ = Console.ReadLine();
                    Console.WriteLine("Enter the new fruit name to update:");
                    string newFru = Console.ReadLine();
                    SearchFunction sch = new SearchFunction();
                   sch.searchFru(list,targ,newFru);
                   
                }
                else if (opt == 4) 
                {
                    Console.WriteLine("Enter the fruit name to delete:");
                    string remFruit = Console.ReadLine();
                    if (CheckingPresentOrNot.isPresent(list, remFruit))
                    {
                        if (list.Remove(remFruit))
                        {
                            Console.WriteLine($"{remFruit} has been removed from the fruits list.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{remFruit} is not present in the fruits list.");
                    }
                }
                else
                {
                    Console.WriteLine("The option you selected is not valid. Please select a valid option.");
                    break;
                }
            }
        }
    }
}
