using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class LocalFunctions
    {
        public void PrintFibonacci()
        {
            Console.WriteLine($"Six item in fibonacci {Fibonacci(6)}");
            // 1,2,3,5,8,13
        }

        int Fibonacci(int x)
        {
            return Fib(x).current;
            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);

                var (current, previous) = Fib(i - 1);
                return (current + previous, current);
            }
        }
    }
}
