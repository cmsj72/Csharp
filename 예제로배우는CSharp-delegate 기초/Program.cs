using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_delegate_기초
{
    //  Delegate는 메서드를 다른 메서드로 전달할 수 있도록 하기 위해 만들어짐
    //  Delegate는 메서드의 입력 파라미터로 피호출자에게 전달될 수 있을 뿐만 아니라, 
    //  메서드의 리턴값으로 호출자에게 전달 할 수도 있다.

    //  정의 방법
    //  delegate int MyDelegate(string s);
    //  delegate 정의에서 중요한 것은 입력 파라미터들과 리턴 타입
    //  만약 어떤 메서드가 이러한 delegate 메서드 원형(Prototype)과 일치한다면,
    //  즉 입력 파라미터 타입 및 갯수, 리턴 타입이 동일하다면 그 메서드는
    //  해당 delegate에서 사용될 수 있다.

    
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
        }
        //  델리게이트 정의
        delegate int MyDelegate(string s);
        void Test()
        {
            //  new를 써서 델리게이트 객체를 생성
            MyDelegate m = new MyDelegate(StringToInt);

            //  델리게이트 대상이 되는 어떤 메서드
            Run(m);
        }
        
        //  델리게이트 대상이 되는 어떤 메서드
        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        //  델리게이트를 전달 받는 메서드
        void Run(MyDelegate m)
        {
            //  델리게이트로부터 메서드 실행
            int a = m.Invoke("123");
            int i = m("123");

            Console.WriteLine(i);
        }
    }
}
