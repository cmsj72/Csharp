using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            //  C#의 yield 키워드는 호출자(Caller)에게 콜렉션 데이터를 하나씩 리턴할 때 사용
            //  Enumerator(Iterator)라고 불리우는 이러한 기능은 집합적인 데이터셋으로부터 데이터를 하나씩
            //  호출자에게 보내주는 역할을 한다.

            //  yield는 yield return 또는 yield break의 2가지 방식으로 사용
            //  (1) yield return은 컬렉션 데이터를 하나씩 리턴하는데 사용
            //  (2) yield break는 리턴을 중지하고 Iteration루프를 빠져 나올 때 사용

            //  다음 내용은 C#고급 문법에 가깝고 분량이 많기 때문에
            //  https://www.csharpstudy.com/CSharp/CSharp-yield.aspx
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }

        static IEnumerable<int> GetNumber()
        {
            yield return 10;//  첫번째 루프에서 리턴되는 값
            yield return 20;//  두번째 루프에서 리턴되는 값
            yield return 30;//  세번째 루프에서 리턴되는 값
        }
    }
}
