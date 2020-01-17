using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tmp;            
            Console.Write("How big will the array be? n=");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab1 = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.Write("Tell me {0}", i+1);
                tab1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (tab1[i]>tab1[j]) { tmp = tab1[i]; tab1[i] = tab1[j]; tab1[j] = tmp; }

                }
            }
            Console.WriteLine("Array Elemets:");
            foreach (int elem in tab1) Console.WriteLine(elem);
            Console.ReadKey();
        }
    }
}
