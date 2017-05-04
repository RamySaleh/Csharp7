using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Csharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static using demo
            new StaticUsing().CallStaticMethodWithoutClassName();
            WriteLine("----------------------------");

            // Out variable demo
            new OutVariable().RunOldWay();
            new OutVariable().RunNewWay();
            WriteLine("----------------------------");

            ReadKey();
        }
    }
}
