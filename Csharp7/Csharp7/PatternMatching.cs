using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class PatternMatching
    {

        public void PrintSumOld(object o)
        {
            if (o is null) return; // Constant pattern
            if (!(o is int i)) return; // Type pattern

            int sum = 0;
            for (int j = 0; j <= i; j++)
            {
                sum += j;
            }

            Console.WriteLine($"The sum from 1 to {i} is {sum} -- old way");
        }

        public void PrintSumNew(object o)
        {
            if (o is int i || o is string s && int.TryParse(s, out i))
            {
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += j;
                }

                Console.WriteLine($"The sum from 1 to {i} is {sum} -- new way");
            }
        }
    }
}
