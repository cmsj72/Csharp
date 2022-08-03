using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
{
    /*class A
    {
        private void PrintPrivate()
        {
            Console.WriteLine("private");
        }

        protected void PrintProtected()
        {
            Console.WriteLine("protected");
        }

        public void PrintPublic()
        {
            Console.WriteLine("public");
        }
    }

    class B : A
    {
        public void Print()
        {
            //PrintPrivate();
            PrintProtected();
            PrintPublic();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.PrintPublic();
        }
    }*/


    /*class A
    {
        public A()
        {
            Console.WriteLine("A 생성자");
        }

        ~A()
        {
            Console.WriteLine("A 소멸자");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B 생성자");
        }

        ~B()
        {
            Console.WriteLine("B 소멸자");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
        }
    }*/


    /*class A
    {
        int number;
        protected string name = "Hello";
        public A(int num)
        {
            number = num;
        }

        public void PrintA()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        string name = "World";
        public B(int num) : base(num)
        {
            //상위 클래스의 생성자 호출
        }

        public void PrintB()
        {
            Console.WriteLine("{0} {1}", base.name, name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B(3);
            Test.PrintA();
            Test.PrintB();
        }
    }*/

    /*class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();

            A Test1 = Test;
            // Test1는 Test를 참조, 업캐스팅, B의 상위 클래스인 A를 참조
            // 하지만 Print에 virtual 이 있고 하위 클래스에 override된 Print가 있기 때문에
            // 하위 클래스인 B의 Print를 실행
        }
    }*/


    /*class A
    {
        public void Print() { Console.WriteLine("Hi!"); }
        public void Print(int number)
        {
            Console.WriteLine(number);
        }
        public float Print(int number, float pi)
        {
            Console.WriteLine("{0} {1}", number, pi);
            return pi;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            Test.Print();
            Test.Print(100);

            float pi = Test.Print(3, 3.14f);
            Console.WriteLine(pi);
        }
    }*/


    /*abstract class A
    {
        int number = 3;
        public abstract void Print();
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("abstract class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.PrintNumber();

            //A Test1 = new A();
        }
    }*/


    /*class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test1 = new A();
            Test1.Print();

            //------------------ cast 형을 이용한 참조
            B Test2 = new B();
            A Test3 = Test2;
            // = A Test3 = (A)Test2;
            Test3.Print();
        }
    }*/

    /*struct DATA
    {
        public string name;
        public int number;

        public DATA(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            object obj = num;
            int result = (int)obj;
            Console.WriteLine("{0} {1}", num, result);

            //---------------------------------------

            DATA Test = new DATA("test", 3);
            object obj1 = Test;
            DATA Test1 = (DATA)obj1;
            Console.WriteLine("{0} {1}", Test1.name, Test.number);
        }
    }*/

    class A
    {
        public void PrintA() { Console.WriteLine("Hello"); }
    }

    class B : A
    {
        public void PrintB() { Console.WriteLine("World"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test1 = new B();
            object obj = Test1;// 참조, 모든 객체의 최상위 클래스는 object 이기 때문에 다형성의 예 이다. (박싱, 언박싱 X)
            A Test2 = (A)obj;
            Test2.PrintA();
            Test1.PrintB();
        }
    }
}
