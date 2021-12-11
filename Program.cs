using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Random()
        {
            Console.WriteLine("Please, enter the amount of the array numbers:\t");
            int amountOfArrayNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min value of the array:\t");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value of the array:\t");
            int maxValue = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int[] b = new int[amountOfArrayNumbers];
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Your array:");
                b[i] = ran.Next(minValue, maxValue);
                Console.Write(b[i] + " ");
            }
        }
        static void Handmade()
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
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];          
            for (int i = 0; i < b.Length; i++)
            {                
                b[i] = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("Введений вами масив:");
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine(b[j]);
            }
            Console.ReadKey();
        }
    }
}
