using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ms = new MyStruct(5);
            using (ms)
            {
                ms.Foo();
            }
            Console.WriteLine(ms.a);
            Console.Read();
        }
    }
    public struct MyStruct : IDisposable
    {
        public int a;
        public MyStruct(int a)
        {
            this.a = a;
        }
        public void Foo()
        {
            a = 7;
        }
        public void Dispose()
        {
            a = 0;
        }
    }
}
