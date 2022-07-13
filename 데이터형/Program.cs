using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 데이터형
{
    /*class Program
    {
        static bool BoolVar;
        //  main은 반드시 static
        static void Main(string[] args)
        {
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);
        }
    }*/



    /*class Program
    {
        //  main은 반드시 static
        static void Main(string[] args)
        {
            char Mun = '7';
            int Num = Mun;
            Num = Num + 1;
            Console.WriteLine("Mun = {0} 문자상수값 = {1} 유니코드 문자 = {2}", (int)Mun, Num, (char)Num);

            Mun = (char)Num;
            Console.WriteLine(Mun);
        }
    }*/

    /*class Program
    {
        //  main은 반드시 static
        static void Main(string[] args)
        {
            int Result;
            byte x = 1, y = 2;
            Result = x + y;
            Console.WriteLine(Result);
        }
    }*/

    /*class Program
    {
        //  main은 반드시 static
        static void Main(string[] args)
        {
            Console.WriteLine("{0} ~ {1}", short.MinValue, short.MaxValue);            
        }
    }*/

    /*class Program
    {
        //  main은 반드시 static
        static void Main(string[] args)
        {
            *//*string str1 = "Hello ";
            string str2 = "World!.";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello World!")
            {
                Console.WriteLine("같음");
            }
            else
            {
                Console.WriteLine("다름");
            }*/

    /*string str1 = "Hello World!";
    Console.WriteLine("문자 개수: {0}", str1.Length);*//*

    string str1 = "C:\\temp\\test.txt";
    string str2 = @"C:\\temp\test.txt";
    Console.WriteLine("{0} {1}", str1, str2);
}
}*/

    /*class Program
    {
        static void Main(string[] args)
        {
            var value1 = 3.14f;
            float value2 = 10.0f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f2} {2}", value1, value2, sum);
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int? Num1 = null;
            if (Num1.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("null 값");
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            int value1 = 127;
            string str1 = value1.ToString();
            Console.WriteLine(str1);

            int value2 = Convert.ToInt32(str1);
            Console.WriteLine(value2);

            string str2 = "3.14";
            float value3 = float.Parse(str2);
            Console.WriteLine(value3);
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            *//*int i = 123;
            object obj = i;
            Console.WriteLine("{0}", (int)obj);*//*

            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine("{0} {1}", i, (int)o);
            //  별도의 메모리를 사용하기 때문에 i를 456으로 바꿔도 o의 내용은 바뀌지 않는다.
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            *//*ConsoleKeyInfo KeyInfo;
            do
            {
                KeyInfo = Console.ReadKey();
                //  대,소 문자를 구분하지 않는다.
                if (KeyInfo.Key == ConsoleKey.A)
                    Console.WriteLine("a가 눌렸다");
            } while (KeyInfo.Key != ConsoleKey.Escape);*//*

            ConsoleKeyInfo KeyInfo;
            do
            {
                KeyInfo = Console.ReadKey(true);
                if (KeyInfo.KeyChar == 'a')
                    Console.WriteLine("a가 눌렸어");
                Console.WriteLine(KeyInfo.KeyChar);
            } while (KeyInfo.Key != ConsoleKey.Escape);
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            int Kor, Eng, Math, Total;
            float Average;

            Console.Write("국어 점수를 입력해 주세요 : ");
            Kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수를 입력해 주세요 : ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수를 입력해 주세요 : ");
            Math = Convert.ToInt32(Console.ReadLine());
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4:f1}", Kor, Eng, Math, Total, Average);
        }
    }
}
