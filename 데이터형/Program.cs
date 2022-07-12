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

    class Program
    {
        //  main은 반드시 static
        static void Main(string[] args)
        {
            /*string str1 = "Hello ";
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
            Console.WriteLine("문자 개수: {0}", str1.Length);*/

            string str1 = "C:\\temp\\test.txt";
            string str2 = @"C:\\temp\test.txt";
            Console.WriteLine("{0} {1}", str1, str2);
        }
    }
}
