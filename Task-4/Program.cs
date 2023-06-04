using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Storage<int>();
            var b = new Storage<int>();
            var c = new Storage<string>();
            Console.WriteLine(a.GetX);
            Console.WriteLine(b.GetX);
            Console.WriteLine(c.GetX);
            Console.Read();
        }
    }
    class Storage<T>
    {
        public static int X { get; protected set; }
        static Storage()
        {
            X++;
        }
        public int GetX
            => X;
    }
}
