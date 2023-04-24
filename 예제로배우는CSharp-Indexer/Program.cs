using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_Indexer
{
    #region C# Indexer
    //  클래스 객체의 데이터를 배열 형태로 인덱스를 써서 엑세스할 수 있게 해준다.
    //  클래스 객체는 배열이 아님에도 불구하고, 마치 배열처럼 []를 써서 클래스 내의
    //  특정 필드 데이터를 엑세스하는 것.
    //  MyClass cls = new MyClass();
    //  cls[0] = "First";
    #endregion

    #region 인덱서 정의
    //  C# Indexer는 특별한 문법인 this[]를 써서 클래스 속성(Property)처럼 get과 set을 정의
    //  클래스 내부의 어떤 데이터를 리턴하는지는 클래스 디자인시 필요에 따라 정하게 될 것이고,
    //  리턴 데이터 타입도 여러가지로 지정할 수 있다.
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        //  내부의 정수 배열 데이터
        private int[] data = new int[MAX];

        //  인덱서 정의. int 파라미터 사용
        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    //  정수 배열로부터 값 리턴
                    return data[index];
                }
            }
            set
            {
                if(!(index < 0 || index >= MAX))
                {
                    //  정수 배열에 값 저장
                    data[index] = value;
                }
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();

            //  인덱서 set 사용
            cls[1] = 1024;

            //  인덱서 get 사용
            int i = cls[1];
        }
    }
    #endregion
    
}
