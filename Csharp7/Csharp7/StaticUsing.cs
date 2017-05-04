using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Csharp7
{
    class StaticUsing
    {
        public void CallStaticMethodWithoutClassName()
        {
            var number = 4;
            WriteLine($"Calling Math.Sqrt on value ({number}) without writing class name = {Sqrt(number)}");
        }
    }
}
