using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    // internal 생략된 형태
    class Date
    {
        /*int Day;
        public int Year, Month;*/

        public int Year;
        protected int Month;
        int Day;
        //  Month 와 Day는 내부에서만 사용 가능

        public void Print()
        {
            Console.WriteLine("{0} {1} {2}", Year, Month, Day);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date Test = new Date();
            Test.Print();
        }
    }
}
