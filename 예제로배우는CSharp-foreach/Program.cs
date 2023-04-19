using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "AB", "CD", "EF" };

            //  foreach 루프
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            //  for vs foreach
            //  성능적 측면은 for가 경우에 따라 약간 빠를 수 있지만 대부분의 경우 성능적 차이는 크지 않으며,
            //  foreach는 for보다 훨신 간결한 코드를 제공한다는 장점이 있다.
            //  루프에서 가장 많이 사용되는 C# 배열(array)의 경우,
            //  foreach가 내부적인 최적화를 거쳐 for 루프와 동일한 성능이므로 더 간결한 foreach를 사용할 것을 권장
            string[,,] arr = new string[,,] {
                    { {"1", "2"}, {"11","22"} },
                    { {"3", "4"}, {"33", "44"} }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                }
            }

            //  3차원 배열의 요소를 모두 처리
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
