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
            WriteLine("-- Static using demo --");
            WriteLine("");
            new StaticUsing().CallStaticMethodWithoutClassName();
            WriteLine("----------------------------");

            // Out variable demo
            WriteLine("-- Out variable demo --");
            WriteLine("");
            var outVariable = new OutVariable();
            outVariable.RunOldWay();
            outVariable.RunNewWay();
            WriteLine("----------------------------");

            // Pattern matching demo
            WriteLine("-- Pattern matching demo --");
            WriteLine("");
            var patternMatching = new PatternMatching();
            patternMatching.PrintSumOld(10);
            patternMatching.PrintSumNew(10);
            WriteLine("----------------------------");

            // Conditional Switch demo
            WriteLine("-- Conditional Switch demo --");
            WriteLine("");
            new ConditionalSwitch().PrintEmployeesDescription();
            WriteLine("----------------------------");

            // Value tuples demo
            WriteLine("-- Value tuples demo --");
            WriteLine("");
            var valueTuple = new ValueTuple();
            valueTuple.PrintTime();
            valueTuple.PrintTimeDecomposed();
            valueTuple.PrintTupleDictionary();
            WriteLine("----------------------------");

            // Local functions demo
            WriteLine("-- Local functions demo --");
            WriteLine("");
            new LocalFunctions().PrintFibonacci();
            WriteLine("----------------------------");

            // Language enhancements demo
            WriteLine("-- Language enhancements demo --");
            WriteLine("");
            new Enhancements().PrintEnhancements();
            WriteLine("----------------------------");

            ReadKey();
        }
    }
}
