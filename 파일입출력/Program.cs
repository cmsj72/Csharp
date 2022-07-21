using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 파일입출력
{
    /*class Program
    {
        static void Main(string[] args)
        {
            *//*int value = 12;
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
            sw.Close();*//*

            //====

            *//*FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
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

            /*StreamReader sr = new StreamReader("test.txt");
            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            Console.WriteLine("{0} {1} {2}", value, value2, str1);*/

            /*string str = "국어: 90 영어: 100 수학: 70";
            //  국어: / 90 / 영어: / 100 / 수학: / 70
            //  0    /  1 /   2   / 3  /   4   /  5 
            string[] str_Element = str.Split(new char[] { ' ' });
            int kor = int.Parse(str_Element[1]);
            int eng = int.Parse(str_Element[3]);
            int math = int.Parse(str_Element[5]);
            int total = kor + eng + math;
            float average = total / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4}", kor, eng, math, total, Math.Round(average));*//*

        }
    }*/

    /*struct GRADE
    {
        public int kor, eng, math, total;
        public float average;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("성적 처리를 위한 학생 수를 입력해 주세요 :");
            int nCount = int.Parse(Console.ReadLine());
            Console.WriteLine("국어 영어 수학 순서로 입력해 주세요");
            GRADE[] Grade = new GRADE[nCount];
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("학생수: {0}", nCount);
            for(int i = 0; i < nCount; i++)
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[] { ' ' });
                Grade[i].kor = int.Parse(DataString[0]);
                Grade[i].eng = int.Parse(DataString[1]);
                Grade[i].math = int.Parse(DataString[2]);
                Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;
                Grade[i].average = Grade[i].total / 3.0f;
                Grade[i].average = (float)Math.Round(Grade[i].average);
            }

            for(int i = 0; i < nCount; i++)
            {
                sw.WriteLine("{0}, {1}, {2}, {3}, {4:f1}", Grade[i].kor, Grade[i].eng, Gr)
            }
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            *//*string str;
            Console.Write("파일명을 입력해 주세요! ");
            string filename = Console.ReadLine();
            StreamReader sr = new StreamReader(filename);
            str = sr.ReadLine();
            string[] strData1 = str.Split(new char[] { ':' });
            int nCount = int.Parse(strData1[1]);
            Console.WriteLine("------------------------------");
            for(int i = 0; i < nCount; i++)
            {
                str = sr.ReadLine();
                string[] strData2 = str.Split(new char[] { ',' });
                Console.WriteLine("{0} {1} {2} {3} {4}", strData2[0], strData2[1], strData2[2], strData2[3], strData2[4]);
            }
            Console.WriteLine("------------------------------");
            sr.Close();*/

            /*using(BinaryWriter bw = new BinaryWriter(new FileStream("test.dat", FileMode.Create)))
            {
                bw.Write(12);
                bw.Write(3.14f);
                bw.Write("Hello World");
            }*//*

            int var1;
            float var2;
            string str1;

            using (BinaryReader br = new BinaryReader(File.Open("test.dat", FileMode.Open)))
            {
                var1 = br.ReadInt32();
                var2 = br.ReadSingle();
                str1 = br.ReadString();
            }

            Console.WriteLine("{0} {1} {2}", var1, var2, str1);
        }
    }*/

    struct Data
    {
        public int var1;
        public float var2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data[] DataArray = new Data[2];

            DataArray[0].var1 = 7;
            DataArray[0].var2 = 3.14f;

            DataArray[1].var1 = 12;
            DataArray[1].var2 = 0.5f;

            BinaryWriter bw = new BinaryWriter(File.Open("test.txt", FileMode.Create));
            for(int i = 0; i < DataArray.Length; i++)
            {
                bw.Write(DataArray[i].var1);
                bw.Write(DataArray[i].var2);
            }

            bw.Close();

            int var1;
            float var2;

            BinaryReader br = new BinaryReader(File.Open("test.txt", FileMode.Open));

            while (true)
            {
                try
                {
                    var1 = br.ReadInt32();
                    var2 = br.ReadSingle();
                    Console.WriteLine("{0} {1}", var1, var2);
                }
                catch(EndOfStreamException e)
                {
                    br.Close();
                    break;
                }
            }
        }
    }
}
