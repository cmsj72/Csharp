using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_enum
{
    class Program
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }
        static void Main(string[] args)
        {
            //  enum은 열거형 상수(constant)를 표현하기 위한 것,
            //  상수 숫자들을 보다 의미있는 단어들로 표현

            //  플래그(flag) enum
            //  enum의 각 멤버들은 각 비트별로 구분되는 값들(1,2,4,8...)을 가질 수 있다.
            //  이렇게 enum 타입이 비트 필드를 갖는다는 것을 표시하기 위해 enum 선언문 바로 위에
            //  [Flags]라는 Attribute (Type 혹은 그 멤버를 선언할 때 그 위에 붙이는 특별한 특성값으로
            //  해당 타입 혹은 멤버가 어떤 특성을 갖고 있는지 나타내게 된다)

            //  [Flags] 특성을 갖는 플래그 enum은 OR 연산자를 이용해서 한 enum 변수에 다중값(예: 1+4)을 가질 수 있으며,
            //  AND 연산자를 이용하여 enum 변수가 특정 멤버를 포함하고 있는지 체크할 수 있다.

            //  OR 연산자로 다중 플래그 할당
            Border b = Border.Top | Border.Bottom;

            //  & 연산자로 플래그 체크
            if ((b & Border.Top) != 0)
            {
                if (b.HasFlag(Border.Bottom))
                {
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}
