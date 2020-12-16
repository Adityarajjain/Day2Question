using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for(int i=min;i<=max;i++)
            {
                bool flag = false;
                for(int j=2;j<=(Math.Sqrt(i));j++)
                {
                    flag = false;
                    if (i % j == 0)
                    { flag = true; break; }
                }
                if (!flag)
                    Console.WriteLine(i + "\t");
            }
        }
    }
}
