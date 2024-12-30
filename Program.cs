using System;
using Pratice;

namespace Practice
{
    class Fruits
    {
        static void Main()
        {
            //string[] fruits = { "Orange", "Apple", "Banana" };
            //String[] fruitsDublicate = (string[])fruits.Clone();
            //Console.WriteLine("Available fruits: " + string.Join(", ", fruits));
            //Console.WriteLine("Please enter a fruit name to replace:");

            //string inputFruit = Console.ReadLine();
            //bool fruitFound = false;


            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    if (string.Equals(fruits[i], inputFruit, StringComparison.OrdinalIgnoreCase))
            //    {
            //        fruitFound = true;


            //        Console.WriteLine("Please enter the new fruit name to replace it:");
            //        fruits[i] = Console.ReadLine();

            //        Console.WriteLine("Updated list of fruits: " + string.Join(", ", fruits));
            //        break;
            //    }
            //}

            //if (!fruitFound)
            //{
            //    Console.WriteLine("The fruit name you entered is not available.");
            //}
            //Console.WriteLine("Menu");
            //Console.WriteLine($"1. Array before Updation :"+string.Join(", ", fruitsDublicate));
            //Console.WriteLine($"2. Array After  Updation :" + string.Join(", ", fruits));
            //while (true)
            //{
            //    int option = Convert.ToInt32(Console.ReadLine());

            //    if (option == 1)
            //    {
            //        Console.WriteLine("Available fruits: " + string.Join(", ", fruitsDublicate));
            //    }
            //    else if (option == 2)
            //    {
            //        Console.WriteLine("Updated list of fruits: " + string.Join(", ", fruits));
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}

            //string str = "She sells sea shell on the sea shore";
            //int NoOfWords = str.Split(' ').Length;

            //Console.WriteLine($"Number of words in a string is {NoOfWords}.");

            //int fre = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 's')
            //    {
            //        fre++;
            //    }
            //}
            //Console.WriteLine($"'s' Occured {fre} times in String");

            ArrayPractice ap = new ArrayPractice();
            ap.showArray();

        }
    }

}