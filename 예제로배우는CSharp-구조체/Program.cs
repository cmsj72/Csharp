using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_구조체
{
    class Program
    {
        //  Value Type vs Reference Type
        //  C#에서는 struct를 사용하면 Value Type을 만들고, class를 사용하면 Reference Type을 만든다

        //  C# .NET의 기본 데이터형들은 struct로 정의, 모두 Value Type이다. 
        //  Value Type은 상속될 수 없으며, 상대적으로 간단한 데이터 값을 저장하는데 사용

        //  Reference Type은 class를 정의하여 만들며 상속이 가능

        //  Value Type의 파라미터 전달은 데이터를 복사(copy)하여 전달, 
        //  Reference Type은 Heap 상의 객체에 대한 레퍼런스(reference)를 전달하여 이루어짐

        //  C#의 구조체는 클래스와 같이 메서드, 프로퍼티 등 거의 비슷한 구조를 가지고 있지만, 상속은 불가능
        //  C# 구조체가 상속은 할 수는 없어도, 클래스와 마찬가지로 인터페이스 구현 가능

        struct MyPoint
        {
            public int X;
            public int Y;
            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }
        }

        static void Main(string[] args)
        {
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }
}
