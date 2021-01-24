using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This program is designed to test my understanding of the Liskov Substitution Principle.");
            //adding fruit to list
            List<Fruit> fruitList = new List<Fruit>();
            fruitList.Add(new Apple());
            fruitList.Add(new Banana());
            fruitList.Add(new Grapefruit());
            while (true)
            {
                Console.WriteLine("Please enter 1, 2, or 3 to get some infromation on fruit. Enter any other number to exit the program");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput > 3 || userInput < 1)
                {
                    break;
                }
                foreach (Fruit fruit in fruitList)
                {
                    if(userInput == fruit.OrderNumber)
                    {
                        Console.WriteLine(fruit.GetFruitInfo());
                    }
                    
                    
                }

            }
        }
    }
}
