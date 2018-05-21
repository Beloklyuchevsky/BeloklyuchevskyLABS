using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class A
    {
        public float b;
        public float a;
        public float c;
        public float C
        {
            get
            {

                for (int g = 1; g <= 3; g++)
                {
                    c = (a + g) + b;

                }
                return c;
            }
            set
            {
                c = value;
            }
        }
        public A(float a, float b)
        {
            a = 2;
            b = 4;
        }
        public A() { }
    }
    class B : A
    {
        public float d;
        public float c2;
            public float C2
        {
            get
            {
                c2 = a * b + d;
                return c2;
            }
            set
            {
                c2 = value;
            }
        }
        public B()
        {
        }
        public B(float a, float b, float d) : base(a, b)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.a = 1;
            obj.b = 2;
            B obj1 = new B( 1, 2, 3);
            obj1.d = 1;
            obj1.a = obj.a;
            obj1.b = obj.b;
            Console.WriteLine("В классе A a={0} b={1} c={2}", obj.a, obj.b, obj.C);
            Console.WriteLine("В классе B a={0} b={1} c2={2} d={3}", obj1.a, obj1.b, obj1.C2, obj1.d);
            Console.ReadKey();
        }
    }
}