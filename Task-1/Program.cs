using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Action<string> action = null;
                AddMethods(action);
                action("Hello world");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        static void AddMethods(Action<string> action)
        {
            action += Console.WriteLine;
            action += Console.WriteLine;
            action -= Console.WriteLine;
        }
    }
}
