using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class ValueTuple
    {
        public void PrintTime()
        {
            var time = GetTime();
            Console.WriteLine($"{time.hour}:{time.minutes}:{time.seconds}");
        }

        public void PrintTimeDecomposed()
        {
            var(hour, minutes, seconds) = GetTime2();
            (int hour2,int minutes2,int seconds2) = GetTime2();

            Console.WriteLine($"{hour}:{minutes}:{seconds}");
            Console.WriteLine($"{hour2}:{minutes2}:{seconds2}");
        }

        private (int hour, int minutes, int seconds) GetTime()
        {
            return (1,30,20); // Literal tuple
        }

        private (int , int , int ) GetTime2()
        {
            return (1, 30, 20); // Literal tuple
        }

        public void PrintTupleDictionary()
        {
            var dictionary = new Dictionary<(int, int), string>();

            dictionary.Add((100, 20), $"You room number is 100 on the 20th floor");
            dictionary.Add((50, 10), $"You room number is 50 on the 10th floor");

            Console.WriteLine(dictionary[(50, 10)]);
        }
    }
}
