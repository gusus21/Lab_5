using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
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
