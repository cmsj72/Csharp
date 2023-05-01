using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_delegate1
{
    #region delegate의 개념
    //  C/C++의 함수 포인터와 비슷한 개념, 메서드 파라미터와 리턴 타입에 대한
    //  정의를 한 후, 동일한 파라미터와 리턴 타입을 가진 메서드를
    //  서로 호환해서 불러 쓸 수 있는 기능
    namespace Delegate_Concept
    {
        class MyClass
        {
            private delegate void RunDelegate(int i);

            private void RunThis(int val)
            {
                //  콘솔출력 : 1024
                Console.WriteLine("{0}", val);
            }

            private void RunThat(int value)
            {
                //  콘솔출력 : 0x400
                Console.WriteLine("0x{0:X}", value);
            }

            public void Perform()
            {
                //  2. delegate 인스턴스 생성
                RunDelegate run = new RunDelegate(RunThis);
                //  3. delegate 실행
                run(1024);

                //  run = new RunDelegate(RunThat); 을 줄여서
                //  아래와 같이 쓸 수 있다.
                run = RunThat;
                run(1024);
            }
        }
        
        class Program
        {
            static void Main(string[] args)
            {
                MyClass mc = new MyClass();
                mc.Perform();
            }
        }
    }
    #endregion

    #region Delegate를 메서드 파라미터로 전달
    //  delegate는 동일한 함수 Prototype을 갖는 메서드를 가리키므로 함수의 포인터를 파라미터로 전달하듯,
    //  다른 함수의 파라미터로 사용될 수 있다.
    //  delegate 파라미터를 전달받은 쪽은 이를 자신의 내부 함수를 호출하듯 사용할 수 있다.

    //  (C# delegate는 내부적으로 .NET Delegate / MulticastDelegate 클래스를 사용
    //  따라서 이 클래스가 지원하는 속성 (예: .Method - 함수 Prototype을 보여줌)과 메서드
    //  (예: GetInvokcationList())를 모두 사용할 수 있다
    namespace Delegate_parameter
    {
        class MySort
        {
            //  델리게이트 COmpareDelegate 선언
            public delegate int CompareDelegate(int i1, int i2);

            public static void Sort(int[] arr, CompareDelegate comp)
            {
                if (arr.Length < 2) return;
                Console.WriteLine("함수 Prototype: " + comp.Method);

                int ret;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        ret = comp(arr[i], arr[j]);
                        if (ret == -1)
                        {
                            //  교환
                            int tmp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = tmp;
                        }
                    }
                }
                Display(arr);
            }
            static void Display(int[] arr)
            {
                foreach (var i in arr) Console.Write(i + " ");
                Console.WriteLine();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                (new Program()).Run();
            }

            void Run()
            {
                int[] a = { 5, 53, 3, 7, 1 };

                //  올림차순으로 정렬
                MySort.CompareDelegate compDelegate = AscendingCompare;
                MySort.Sort(a, compDelegate);

                //  내림차순으로 정렬
                compDelegate = DescendingCompare;
                MySort.Sort(a, compDelegate);
            }

            int AscendingCompare(int i1, int i2)
            {
                if (i1 == i2) return 0;
                return (i2 - i1) > 0 ? 1 : -1;
            }

            int DescendingCompare(int i1, int i2)
            {
                if (i1 == i2) return 0;
                return (i1 - i2) > 0 ? 1 : -1;
            }
        }
    }
    #endregion
}
