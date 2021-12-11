using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Randomfill()
        {
            Console.WriteLine("Please, enter the amount of the array numbers:\t");
            int amountOfArrayNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min value of the array:\t");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value of the array:\t");
            int maxValue = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int[] myArray = new int[amountOfArrayNumbers];
            Console.WriteLine("Your array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = ran.Next(minValue, maxValue);
                Console.Write(myArray[i] + " ");                
            }
            Console.ReadLine();
        }
        static void HandmadeEnter()
        {
            Console.WriteLine("Please, enter the amount of the array numbers:\t");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter the number on {i} index:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введений вами масив:");
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine(myArray[j]);
            }
        }
        static void HandmadeSpaces()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int[] myArray;
            
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What type of array input you want(1-hand; 2-random)");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        string ch = Console.ReadLine();
                        if (ch == "enter")
                        {
                            HandmadeEnter();
                        }
                        else if (ch == "spaces")
                            HandmadeSpaces();
                        else
                            Console.WriteLine("Error");
                        break;
                    }
                case 2:
                    {
                        Randomfill();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Bruh, I say, 1 or 2. I lazzy programer and I don't want give you a chance to repeat, hehe ^_^");
                        break;
                    }
            }
        }
    }
}
