using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

    /*class Program
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
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int nNum = 10;
            if (true)
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine("C# Programming");
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int nNum = 1;
            switch (nNum)
            {
                case 1: // break 문이 없으면 진행하지 않는다.
                    Console.WriteLine("1 입니다.");
                    break;

                case 2:
                    Console.WriteLine("2 입니다");
                    break;
            }

            string str = "yes";
            switch (str)
            {
                case "no":
                    Console.WriteLine("no");
                    break;

                case "yes":
                    Console.WriteLine("yes");
                    break;
            }

            char value = 'a';// ← 유니코드, 단, 유니코드와 아스키코드의 문자키 값이 같다.
            switch (value)
            {
                case 'a':
                    Console.WriteLine("a");
                    break;

                case 'b':
                    Console.WriteLine("b");
                    break;
            }
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3, 4 };

            foreach(int nValue in Array1)
            {
                Console.WriteLine(nValue);
            }

            //  Collections 를 쓰기 위해서 using System.Collections 를 추가해야함
            ArrayList List = new ArrayList();
            List.Add(1);
            List.Add(2);
            List.Add(3);

            foreach(int m in List)
            {
                Console.WriteLine(m);
            }
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                array[3] = 10;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("배열 인덱스 에러 발생");
                Console.WriteLine(e.ToString());
                array[2] = 10;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} ", array[i]);
            }

            //=====

            int m = 0;
            //int m;
            try
            {
                m = 12;
                Console.WriteLine("try문 출력 : {0}", m);
            }
            catch
            {
                Console.WriteLine("예외 발생");
            }

            Console.WriteLine("try 문 밖에서 변수 출력 {0}", m); // ← 에러 표시

            //=====

            int[] array2 = { 1, 2, 3 };
            try
            {
                Console.WriteLine("try 문에서 예외 발생시킵니다.");
                array[3] = 10;
            }
            finally
            {
                Console.WriteLine("finally 구문 입니다.");
            }

            foreach (var m1 in array)
                Console.WriteLine("{0} ", m1);

            //=====

            int n = 0;
            try
            {
                n = 12;
            }
            finally
            {
                n = 100;
                Console.WriteLine("finally 문 n 값 : {0}", n);
            }

            n = 200;
            Console.WriteLine("try finally문 밖에서 실행 n 값 :{0}", n);
        }
    }*/

    class Program
    {
        static int GetNumber(int index)
        {
            int[] nums = { 300, 600, 900 };
            if (index >= nums.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return nums[index];
        }

        static void Main(string[] args)
        {
            int result = GetNumber(3);
        }
    }

}
