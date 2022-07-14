using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 데이터형2
{
    /*public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);
        }
    }*/

    /*public struct MyStruct
    {
        public int Age;
        public MyStruct(int InAge)
        {
            Age = InAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            MyStruct TestStruct2 = new MyStruct();
            Console.WriteLine(TestStruct2.Age);

            MyStruct TestStruct3 = new MyStruct(12);
            Console.WriteLine("{0}", TestStruct3.Age);
        }
    }*/

    /*public struct MyStruct
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  단순히 선언해서 사용하는것보다 new 를 통해서 선언하는것이 안전하다.
            MyStruct TestStruct1, TestStruct2;
            MyStruct test;
            TestStruct2.Age = 10;
            test = new MyStruct();
            Console.WriteLine(test.Age);
            TestStruct1 = TestStruct2;
            Console.WriteLine("{0}", TestStruct1.Age);
        }
    }*/

    /*public struct MyStruct
    {
        public int Age;
    }
    class MyClass
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct test1 = new MyStruct();
            test1.Age = 12;
            MyStruct test2 = test1;
            test2.Age = 24;
            Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3;
            test4.Age = 24;
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);
        }
    }*/

    /*public struct MyStruct
    {
        public int Age;
        public float Num2;
        public bool IsReady;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct test = new MyStruct();
            Console.WriteLine("{0} {1} {2}", test.IsReady, test.Age, test.Num2);
        }
    }*/

    /*public struct MyStruct
    {
        public int Kor, Eng, Math, Total;
        public float Average;

        public void Compute()
        {
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyStruct Test1 = new MyStruct();
                Test1.Kor = 80;
                Test1.Eng = 90;
                Test1.Math = 88;
                Test1.Compute();
                Console.WriteLine("총점 : {0} 평균 : {1}", Test1.Total, Test1.Average);
            }
        }
    }*/

    /*enum Days { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat};
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = (int)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int nVal1 = 12;
            int nVal2 = new int();
            Console.WriteLine("{0} {1}", nVal1, nVal2);
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3 };
            int[] RefArray; // 참조형 배열 변수
            RefArray = Array1;
            RefArray[1] = 20;
            Console.WriteLine("{0} {1} {2}", Array1[0], Array1[1], Array1[2]);
        }
    }
}
