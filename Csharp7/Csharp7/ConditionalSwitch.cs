using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class ConditionalSwitch
    {
        public void PrintEmployeesDescription()
        {
            Employee employee1 = new Manager();
            employee1.Name = "Ramy saleh";
            (employee1 as Manager).StockShare = 6000;

            Employee employee2 = new Manager();
            employee2.Name = "Ahmed aly";
            (employee2 as Manager).StockShare = 4500;

            PrintDescription(employee1);

            PrintDescription(employee2);
        }

        void PrintDescription(Employee employee)
        {
            switch (employee)
            {
                case Manager m when m.StockShare < 5000:
                    Console.WriteLine($"{m.Name} has {m.StockShare} shares so he is a junior manager");
                    break;
                case Manager m when m.StockShare >= 5000:
                    Console.WriteLine($"{m.Name} has {m.StockShare} shares so he is a Senior manager");
                    break;
                case Employee e:
                    Console.WriteLine($"{e.Name} is a regular employee");
                    break;
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
    }


    class Manager : Employee
    {
        public int StockShare { get; set; }
    }
}
