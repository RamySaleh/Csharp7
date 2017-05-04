using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class Enhancements
    {
        public void PrintEnhancements()
        {
            Console.WriteLine($"Big number : {GetBigNumber()}");

            int[] numbers = { 2, 7, 3, 2, 12, 8, 15 };
            ref int item = ref GetItemAt(4, numbers);
            item = -12;

            Console.WriteLine($"5th item value became {numbers[4]}");
                        
            Console.WriteLine($"new InputParam(null).InputName -> Throws ArgumentNullException if constructor is passed null");
        }

        private int GetBigNumber()
        {
            return 1_234_567;
        }

        private ref int GetItemAt(int index, int[] numbers)
        {
            return ref numbers[index];
        }
                
    }

    class InputParam
    {
        public string InputName { get; set; }

        public InputParam(string inputName) => InputName = inputName ?? throw new ArgumentNullException();
    }
}
