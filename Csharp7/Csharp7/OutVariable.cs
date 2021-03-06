﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class OutVariable
    {
        public void RunOldWay()
        {
            int hour;
            int minutes;
            int seconds;
            GetTime(out hour, out minutes, out seconds);
            Console.WriteLine($"{hour}:{minutes}:{seconds} -- old way");
        }

        public void RunNewWay()
        {
            GetTime(out var hour, out var minutes, out int seconds);
            Console.WriteLine($"{hour}:{minutes}:{seconds} -- new way");
        }

        private void GetTime(out int hour, out int minutes, out int seconds)
        {
            hour = 1;
            minutes = 30;
            seconds = 20;
        }
    }
}
