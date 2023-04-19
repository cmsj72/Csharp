using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_메서드
{
    class Program
    {
        #region Pass by Value
        //  C#은 메서드에 인수를 전달할 때, 디폴트로 값을 복사해서 전달하는 Pass by Value방식을 따른다.
        //  만약 전달된 인수를 메서드 내에서 변경한다해도 메서드가 끝나고 함수가 리턴된 후,
        //  전달되었던 인수의 값은 호출자에서 원래 값 그대로 유지된다.
        /*private void Calculate(int a)
        {
            a *= 2;
        }

        static void Main(string[] args)
        {
            Method m = new Method();

            int val = 100;
            m.Calculate(val);
            Console.WriteLine(val);
        }*/
        #endregion

        #region Pass by Reference
        //  메서드에 파라미터를 전달할 때, 만약 레퍼런스(참조)로 전달하고자 한다면 C# 키워드 ref를 사용
        //  ref를 사용하기 위해서는 ref로 전달되는 변수가 사전에 초기화되어야 한다.

        //  C# out을 사용하는 파라미터는 메서드 내에서 그 값을 반드시 지정하여 전달하게 되어 있다.
        //  ref는 해당 변수가 사전에 초기화 되어야 하지만, out은 초기화할 필요는 없다.

        //  ref 정의
        /*static double GetData(ref int a, ref double b)
        {
            return ++a * ++b;
        }

        //  out 정의
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        static void Main(string[] args)
        {
            int x = 1;
            double y = 1.0f;
            double ret = GetData(ref x, ref y);

            int c, d;
            bool bret = GetData(10, 20, out c, out d);
            Console.WriteLine("x : {0}, y : {1}, ret : {2}", x, y, ret);
            Console.WriteLine("c : {0}, d : {1}, bret : {2}", c, d, bret);
        }*/
        #endregion

        #region C# 4.0 : Named 파라미터
        //  메서드에 파라미터를 전달할 때, 일반적으로 파라미터 위치에 따라 순차적으로 파라미터가 넘겨진다.
        //  C# 4.0부터는 위치와 상관없이 파라미터명을 지정하여 파라미터를 전달할 수 있게 했다.
        //  이를 Named Parameter라 부른다.
        /*static void NamedPara(string name, int age, int score)
        {
            Console.WriteLine("{0}, {1}, {2}", name, age, score);
        }

        static void Main(string[] args)
        {
            NamedPara(age: 29, score: 90, name: "윤찬호");
        }*/
        #endregion

        #region C# 4.0 : Optional 파라미터
        //  C# 4.0에서부터 어떤 메서드의 파라미터가 디폴트 값을 갖고 있다면,
        //  메서드 호출시 이러한 파라미터를 생략하는 것을 허용. 이를 Optional 파라미터라 부른다.
        //  Optional 파라미터는 반드시 파라미터들 중 맨 마지막에 놓여져야 함
        //  복수개의 Optional 파라미터가 있는 경우 반드시 Optional이 아닌 파라미터들 뒤에 위치해야 한다.
        /*int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        static void Main(string[] args)
        {
            Method m = new Method();
            int ret = m.Calc(1, 2);
            ret = m.Calc(1, 2, "*");
        }*/
        #endregion

        #region params
        //  일반적으로 메서드의 파라미터 갯수는 고정되어 있다.
        //  파라미터의 갯수를 미리 알 수 없는 경우도 있는데, 이런 경우 C# params를 사용
        //  가변적인 배열을 인수로 갖게 해주는데, 파라미터들 중 하나만 존재해야 하며, 맨 마지막에 위치해야 한다.
        /*static void Calc(params int[] values)
        {
            foreach(int r in values)
            {
                Console.WriteLine(r);
            }
        }

        static void Main(string[] args)
        {
            Calc(1, 2, 3, 4);
            Calc(-1, 10, 9, 8, 7);
        }*/
        #endregion
    }
}
