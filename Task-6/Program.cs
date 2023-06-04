using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myInt = new MyGeneric<int>();
            var myStr = new MyGeneric<string>();
            Console.Read();
        }
    }
    class MyGeneric<T>
    {
        static MyGeneric()
        {
            Console.WriteLine("I was called");
        }
    }
}
