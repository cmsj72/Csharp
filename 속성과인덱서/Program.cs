using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 속성과인덱서
{
    /*class A
    {
        private int number;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0 || value > 9)
                    number = 0;
                else
                    number = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            test.Name = "Microsoft C#";
            test.Number = 9;
            Console.WriteLine("{0} {1}", test.Name, test.Number);
            test.Number = 7;
            Console.WriteLine(test.Number);
        }
    }*/


    /*class A
    {
        private int[] number = new int[5];
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            for(int i = 0; i < 5; i++)
            {
                test[i] = i;
                Console.WriteLine(test[i]);
            }
        }
    }*/


    class A
    {
        ArrayList List = new ArrayList();
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < List.Count)
                    return (string)List[index];
                else
                    return null;
            }

            set
            {
                if (index >= 0 && index < List.Count)
                    List[index] = value;
                else if (index == List.Count)
                    List.Add(value);
            }
        }

        public void Print()
        {
            foreach(string m in List)
            {
                Console.WriteLine(m);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            test[0] = "A";
            test[1] = "B";
            test[2] = "C";
            test[3] = "D";

            test.Print();
            test[1] = "Hello World!";
            test.Print();

        }
    }
}
