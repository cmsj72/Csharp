using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_constant
{
    class Program
    {
        //  const
        //  필드 선언부에서 사용되거나 메서드 내에서 사용될 수 있으며,
        //  컴파일시 상수값이 결정
        const int MAX_VALUE = 1024;

        //  읽기전용(개념적으로 상수와 비슷한)필드
        //  필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있고,
        //  런타임시 값이 결정된다.
        readonly int Max;
        /*public CSVar()
        {
            Max = 1;
        }

        static void Main(string[] args)
        {

        }*/
    }
}
