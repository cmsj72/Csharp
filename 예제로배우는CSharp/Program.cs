using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp
{
    #region Nullable Type
    /*class Program
    {
        static void Main(string[] args)
        {
            
            //  Nullable Type
            //  정수(int)나 날짜(DateTime)과 같은 Value Type은 일반적으로 NULL을 가질 수 없다.
            //  C# 2.0에서부터 이러한 타입들에게 NULL을 가질 수 있게 함, 이를 Nullable Type이라 부른다.
            int? i = null;
            i = 101;

            bool? b = null;

            //  int? 혹은 DateTime? 같이 하면 Nullable Type이 된다. 
            //  이는 컴파일하면 .NET의 Nullable<T> 타입으로 변환된다. 
            //  Nullable Type (예: int?) 을 일반 Value Type (예: int)으로 변경하기 위해서는 Nullable의 .Value 속성을 사용한다.
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
            int? i2 = null;
            int a = i2 ?? 100;
            Console.WriteLine(a);
            
        }
    }*/
    #endregion
    #region
    class CSVar
    {
        //  const
        //  필드 선언부에서 사용되거나 메서드 내에서 사용될 수 있으며,
        //  컴파일시 상수값이 결정
        const int MAX_VALUE = 1024;

        //  읽기전용(개념적으로 상수와 비슷한)필드
        //  필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있고,
        //  런타임시 값이 결정된다.
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }

        static void Main(string[] args)
        {

        }
    }
    #endregion
}
