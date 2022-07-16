using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp기본문법
{
    /*class Program
    {
        static void Main(string[] args)
        {
            bool bFlag = false;
            Console.WriteLine("{0} {1} {2}", !bFlag, !true, !false);
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            string str = "3" + ".14";
            Console.WriteLine(+5);              // 숫자 양 5
            Console.WriteLine(5 + 5);           // 숫자 10
            Console.WriteLine(5 + .5);          // 숫자 5.5
            Console.WriteLine("5" + "5");       // 문자열 55
            Console.WriteLine(5.01f + "5");     // 문자열 5.015
            Console.WriteLine(3.14f + "5");     // 문자열 3.145
            Console.WriteLine(str);             // 문자열 3.14
            str = 1 + "test" + 3.14f + "abcd";
            Console.WriteLine(str);             // 문자열이 하나만 있어도 문자열로 실행
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            if (nValue is float)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            if (nValue is object)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            object obj = nValue;
            if (obj is int)
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안 됨");
            }
        }
    }*/

    /*class A { }
    class B { }
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;
            //  test1은 new A()를 통해 생성되었기 때문에 언박싱하면서
            //  as B를 통해 형변환 할 수 없다.
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(y);
            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
        }
    }

}
