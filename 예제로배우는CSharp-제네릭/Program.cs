using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_제네릭
{
    #region C# 제네릭(Generics)
    //  제네릭 타입에서는 int, float, double 같은 데이터 요소 타입을 확정하지 않고
    //  이 데이터 타입 자체를 타입파라미터(Type Parameter)로 받아들이도록 클래스를 정의
    //  C# 제네릭 타입을 사용할 때는 클래스명과 함께 구체적인 데이터 타입을 함께 지정해 주게 된다.
    //  이렇게 하면 일부 상이한 데이터 타입 때문에 여러 개의 클래스들을 따로 만들 필요 X
    //  C# 제네릭은 클래스 이외에도 인터페이스나 메서드에도 적용될 수 있다.
    
    namespace CSharp_Generic
    {
        class MyStack<T>
        {
            T[] _elements;
            int pos = 0;
            public MyStack()
            {
                _elements = new T[100];
            }

            public void Push(T element)
            {
                _elements[++pos] = element;
            }

            public T Pop()
            {
                return _elements[pos--];
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //  두 개의 서로 다른 타입을 갖는 스택 객체를 생성
                MyStack<int> numberStack = new MyStack<int>();
                MyStack<string> nameStack = new MyStack<string>();
            }
        }
    }
    #endregion

    #region .NET Generic 클래스들
    //  .NET Framework에는 상당히 많은 제네릭 클래스들이 포함되어 있는데, 특히
    //  System.Collections.Generic 네임스페이스 에 있는 모든 자료구조 관련 클래스들은 제네릭 타입이다.
    //  List<T>, Dictionary<T>, LinkedList<T> 등이 이 네임스페이스 안에 들어있다.
    namespace Generic_Classes
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> nameList = new List<string>();
                nameList.Add("홍길동");
                nameList.Add("이태백");

                Dictionary<string, int> dic = new Dictionary<string, int>();
                dic["길동"] = 100;
                dic["태백"] = 90;
            }
        }
    }
    #endregion
}
