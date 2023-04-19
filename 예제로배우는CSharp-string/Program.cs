using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string은 .NEY의 System.String 클래스와 동일
            //  System.String 클래스의 모든 메서드와 속성 사용 가능
            //  C# 문자열은 Immutable, 즉 한번 문자열이 설정되면, 다시 변경할 수 없다.
            //  (한번 그 값이 설정되면 다시 변경할 수 없는 타입을 Immutable Type,
            //   반대로 값을 계속 변경할 수 있는 것을 Mutable Type)
            //  s = "C#"; 이라고 한 후 다시 s = "F#"; 이라고 실행하면,
            //  .NET 시스템은 새로운 string 객체를 생성하여 "F#"이라는 데이타로 초기화 한 후 이를 변수명 s 에 할당한다.
            //  변수 s 는 내부적으로는 전혀 다른 메모리를 갖는 객체를 가리키는 것
            string s1 = "C#";
            string s2 = "Programming";
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            //  StringBuilder는 System.Text.StringBuilder 클래스
            //  String은 Immutable Type이기 때문에 문자열 갱신을 많이 하는 프로그램에서는 적당하지 않다
            //  StringBuilder는 Mutable Type 이기 때문에 문자열 갱신이 많은 곳에서 자주 사용
            //  일정한 버퍼를 갖고 문자열 갱신을 효율적으로 처리하기 때문
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
                //sb.Append("\n");
            }
            string s = sb.ToString();

            Console.WriteLine(s);
        }
    }
}
