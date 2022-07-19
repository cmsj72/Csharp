using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 파일입출력
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World!";
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.WriteLine(str1);
            sw.Close();*/

            /*using(StreamWriter sw = new StreamWriter(new FileStream("test1.txt", FileMode.Create)))
            {
                sw.WriteLine(value);
                sw.WriteLine(value2);
                sw.WriteLine(str1);
            }*/

            /*//간단하게 쓰기 용도로만 사용할때는 아래처럼 사용 가능
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.WriteLine(str1);
            sw.Close();*/

            //====

            /*FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            sr.Close();
            Console.WriteLine("{0} {1} {2}", value, value2, str1);*/

            /*using (StreamReader sr = new StreamReader(new FileStream("test.txt", FileMode.Open)))
            {
                int value = int.Parse(sr.ReadLine());
                float value2 = float.Parse(sr.ReadLine());
                string str1 = sr.ReadLine();
                sr.Close();
                Console.WriteLine("{0} {1} {2}", value, value2, str1);
            }*/

            StreamReader sr = new StreamReader("test.txt");
            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            Console.WriteLine("{0} {1} {2}", value, value2, str1);
        }
    }
}
