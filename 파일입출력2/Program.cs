using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace 파일입출력2
{
    /*[Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        public string str1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];

            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "Test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5f;
            Data[1].str1 = "Test2";

            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }

            DATA[] ResultData;

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
            }

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1,
                    ResultData[i].var2, ResultData[i].str1);
            }
        }
    }*/

    /*[Serializable]
    struct DATA
    {
        public int var1;
        public float var2;

        [NonSerialized]
        public string str1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];

            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "Test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5f;
            Data[1].str1 = "Test2";

            using(FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }

            DATA[] ResultData;

            using(FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
            }

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1,
                    ResultData[i].var2, ResultData[i].str1);
            }
        }
    }*/
    [Serializable]
    struct Data
    {
        public int data;
        public string str;
        public Data(int data1, string str1)
        {
            data = data1;
            str = str1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> ResultList;
            List<Data> DataList = new List<Data>();
            DataList.Add(new Data(7, "test1"));
            DataList.Add(new Data(12, "test2"));
            DataList.Add(new Data(12, "test2"));
            DataList.Add(new Data(12, "test2"));
            DataList.Add(new Data(12, "test2"));

            using(FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, DataList);
            }

            using(FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultList = (List<Data>)bf2.Deserialize(fs2);
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
            }
        }
    }
}
