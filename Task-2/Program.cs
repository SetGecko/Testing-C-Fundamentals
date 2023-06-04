using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterator = 0;
            int[] array = { 1, 2, 3, 4, 5, 6};
            var filter = array.Where(n => n > 3).Select(_ => iterator++);
            Console.WriteLine(filter.First());
            Console.WriteLine(iterator);
            Console.ReadKey();
        }
    }
}
