using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
              int n = Convert.ToInt32(Console.ReadLine());
              for(int i=0;i<n;i++)
            {
                Console.WriteLine(" \n" + Fibonacci(i));
            }
            Console.ReadKey();

        }

    public static int Fibonacci(int n)
    {

        if (n == 0)
            return 0;
        else if(n ==1)
          return 1;
        else
        {
         return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
            
        }
    }
}
