using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            A ppp = new A("aaa", "ccc", 21);
            ppp.parsname();
        }
    }
    class A
    {
        public string v;
        public string b;
        public string c;

      public A (string v, string b, int c)
        {
            this.v = v;
        }
    public void parsname()
        {
            if (v is string)
            {
                Console.WriteLine(v);
                Console.ReadKey();
            }
        }  
    }
    class B
    {

    }
    class C
    {

    }
    class D
    {

    }
    class E
    {

    }
}

