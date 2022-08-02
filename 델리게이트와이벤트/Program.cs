using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트와이벤트
{
    /*delegate void DelegateType(string str);
    // string 형 매개변수를 받고 리턴형이 void 인 메서드를 참조하는 delegate 를
    // DelegateType 이라는 이름으로 선언

    class A
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            DelegateType DelMethod1 = new DelegateType(Test.Print); //  C# 1.0 이상에서만
            DelMethod1("Hello Wrold1");

            DelegateType DelMethod2 = Test.Print;   //  C# 2.0 이상에서 사용 가능
            DelMethod2("Hello World2");
        }
    }*/


    /*delegate void DelegateType();
    // 매개변수가 없고 리턴형이 void 인 메서드를 참조하는 delegate 를
    // DelegateType 이라는 이름으로 선언

    class A
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA");
        }

        public void PrintB()
        {
            Console.WriteLine("PrintB");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            DelegateType DelFunc = Test.PrintA;
            DelFunc += Test.PrintB;
            DelFunc();
            DelFunc -= Test.PrintB;
            DelFunc();
        }
    }*/


    delegate void DelegateType(string Message);

    class A
    {
        public event DelegateType EventHandler;

        public void Func(string Message)
        {
            EventHandler(Message);
        }
    }

    class B
    {
        public void PrintA(string Message)
        {
            Console.WriteLine("PrintA " + Message);
        }

        public void PrintB(string Message)
        {
            Console.WriteLine("PrintB " + Message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test1 = new A();
            B Test2 = new B();

            Test1.EventHandler += new DelegateType(Test2.PrintA);
            Test1.EventHandler += new DelegateType(Test2.PrintB);
            Test1.Func("Good!");
            Test1.EventHandler -= Test2.PrintB;
            Test1.Func("Hi!");
            Test1.EventHandler -= Test2.PrintA;

            Test1.EventHandler += Test2.PrintA;
            Test1.EventHandler += Test2.PrintB;

            Test1.Func("Hello World");
        }
    }
}
