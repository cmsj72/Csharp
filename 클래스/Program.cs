using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    // internal 생략된 형태
    /*class Date
    {
        //int Day;
        //public int Year, Month;

        public int Year;
        protected int Month;
        int Day;//생략하면 private
        //  Month 와 Day는 내부에서만 사용 가능

        public void Print()
        {
            Console.WriteLine("{0} {1} {2}", Year, Month, Day);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date Test = new Date();
            Test.Print();
        }
    }*/


    /*class MyClass
    {
        public int val;
        public void PrintA() { Console.WriteLine("Class A"); }
        void PrintB() { Console.WriteLine("Class B"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass();
            test.val = 12;
            Console.WriteLine(test.val);
            test.PrintA();
        }
    }*/


    /*class MyClass
    {
        public int Year, Month, Day;
        public void Print()
        {
            Console.WriteLine("{0}년 {1}월 {2}일", Year, Month, Day);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass();
            MyTest.Year = 2022;
            MyTest.Month = 7;
            MyTest.Day = 24;
            MyTest.Print();
        }
    }*/

    /*class MyClass
    {
        string Message;
        //public MyClass()
        //{
        //  Message = "Hello World";
        //}

        public MyClass(string InputMessage)
        {
            Message = InputMessage;
        }

        public void PringMessage()
        {
            Console.WriteLine(Message);
        }

        ~MyClass()
        {
            Console.WriteLine("소멸자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //MyClass MyTest = new MyClass();
            MyClass MyTest = new MyClass("Happy!");
            MyTest.PringMessage();
        }
    }*/


    /*class MyClass
    {
        public static int number = 12;
        public static void Print() { Console.WriteLine("Hello World"); }
        public void PrintA() { Console.WriteLine("static이 아닌 PrintA()"); }
        public int numberA = 12;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Print();
            Console.WriteLine(MyClass.number);
            MyClass.number = 200;
            MyClass test = new MyClass();
            Console.WriteLine(MyClass.number);
            Console.WriteLine(test.numberA);
            test.numberA = 300;
            Console.WriteLine(test.numberA);
        }
    }*/

    /*class MyClass
    {
        public int number;
        public MyClass()
        {
            number = 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass();
            MyClass RefClass = MyTest;
            RefClass.number = 7;
            Console.WriteLine(MyTest.number);
        }
    }*/


    /*class MyClass
    {
        public int number;
        public MyClass(int number)
        {
            this.number = number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass(12);
            Console.WriteLine(MyTest.number);
        }
    }*/
}
