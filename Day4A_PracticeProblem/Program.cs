using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 4A Practice Problems.");
            bool continueExecution = true;

            while (continueExecution) 
            {
                Console.WriteLine("Please select any one of the following program which you wants to perform");
                Console.WriteLine("1.Nlog problem\n2.CRUD operations on ArrayList");
                
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Please enetr 1st number:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enetr 2nd number:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Addition addition = new Addition();
                        addition.Sum(x, y);
                        break;

                    case 2:
                        ArrayListOperations data = new ArrayListOperations();

                        data.AddFruit("Apple");
                        data.AddFruit("Banana");
                        data.AddFruit("Orange");

                        data.DisplayFruits();

                        data.UpdateFruit("Banana", "Mango");

                        data.DisplayFruits();

                        data.DeleteFruit("Apple");

                        data.DisplayFruits();
                        break;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
                Console.WriteLine("Do you want to continue (yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                } 
            }
            
            Console.ReadLine();
        }
    }
}
