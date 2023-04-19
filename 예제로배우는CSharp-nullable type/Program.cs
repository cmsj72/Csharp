using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_nullable_type
{
    class Program
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
            //  ?? 연산자는 ?? 왼쪽 피연산자의 값이 NULL인 경우 ?? 뒤의 피연산자 값을 리턴하고, 아니면 그냥 ?? 앞의 피연산자 값을 리턴한다. 
            //  ?? 연산자는 왼쪽 피연산자가 NULL이 허용되는 데이타 타입인 경우에만 사용된다.
            int a = i2 ?? 100;
            Console.WriteLine(a);

        }
    }
}
