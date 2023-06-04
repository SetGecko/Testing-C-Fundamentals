using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            i.Increment();
            Console.WriteLine(i);
            Console.Read();
        }
    }
    public static class MyHelper
    {
        public static void Increment(this int i)
        {
            i++;
        }
    }
}
