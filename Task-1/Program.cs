using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите Ваше имя");
            string Name_str = Console.ReadLine();
            string Datatime_str = Convert.ToString(DateTime.Now);
            Console.WriteLine("Привет, " + Name_str + ", сегодня " + Datatime_str);
            Console.WriteLine($"Привет, {Name_str}, сегодня {DateTime.Now}");
            _=Console.ReadLine();
        }
    }
}
