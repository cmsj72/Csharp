using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_클래스_상속
{
    #region C# 파생클래스
    //  부모 클래스인 기준 클래스(Base Class)로부터 상속하여 새로운 파생 클래스(Derived Class)를 만들 수 있다.
    //  상속(inheritance)을 사용하게 되면 Base 클래스의 데이터 및 메서드들을(public 혹은 protected 멤버의 경우)
    //  파생 클래스에서 사용할 수 있게 된다. 파생 클래스는 Base 클래스로부터 물려 받는 멤버들 외에
    //  대게 자기 고유의 메서드와 데이터를 추가해서 사용하게 된다.

    //  제약점은 파생 클래스가 단 하나의 Base 클래스로부터 상속되어져야 한다.
    //  즉, 하나의 파생 클래스는 2개 이상의 Base 클래스를 가질 수 없다.
    
    //  베이스 클래스
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //  파생 클래스
    public class Dog : Animal
    {
        //  베이스 클래스의 Age 속성 사용
        public void HowOld()
        {
            Console.WriteLine("나이: {0}", this.Age);
        }
    }

    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("{0}가 날다", this.Name);
        }
    }
    #endregion

    #region 추상 클래스(Abstract Class)
    //  클래스 명 앞에 abstract라는 키워드가 붙음
    //  추상 클래스로부터는 객체를 직접 생성할 수 없다.

    //  추상 클래스 안에 클래스의 임의의 멤버 앞에 abstract 키워드를 붙이는 경우가 있는데,
    //  이는 해당 멤버가 구현되지 않았으며, 추상 클래스로부터 파생되는 파생 클래스에서
    //  반드시 그 멤버를 구현해 주어야 한다는 것을 의미
    //  파생 클래스에서 상속된 abstract 메서드를 구현하기 위해서는 override 라는 C# 키워드를 사용하여
    //  그 메서드를 새로 정의 하면 된다.
    public abstract class PureBase
    {
        //  abstract C# 키워드
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DerivedA : PureBase
    {
        private int no = 1;

        //  override C# 키워드
        public override int GetFirst()
        {
            return no;
        }

        public override int GetNext()
        {
            return ++no;
        }
    }
    #endregion

    #region public / protected 멤버
    //  클래스 멤버 중 public으로 선언된 멤버들은 (파생 클래스를 포함한) 모든 외부 클래스에서 엑세스 할 수 있다.
    //  다른 외부 클래스에서는 사용하지 못하게 하고 파생 클래스에서만 사용하도록 하고 싶다면,
    //  proteced를 사용

    public class MyBase
    {
        public string Name { get; set; }
        protected int Age { get; set; }
    }

    public class MyDerived : MyBase
    {
        public void Run()
        {
            //  파생클래스이므로 Age 사용 가능
            Console.WriteLine("나이: {0}", this.Age);
        }
    }
    #endregion

    #region as 연산자와 is 연산자
    //  as 연산자는 객체를 지정된 클래스 타입으로 변환하는데 사용
    //  만약 변환이 성공하면 해당 클래스 타입으로 캐스팅하고, 실패하면 null을 리턴

    //  캐스팅(Casting)을 사용하면, 변환이 실패했을 때 Exception을 발생시키는데
    //  이를 catch하지 않으면 프로그램을 중지하게 된다.

    //  is연산자는 is앞에있는 객체가 특정 클래스 타입이나 인터페이스를 갖고 있는지 확인하는데 사용
    namespace asOp_isOp
    {
        class MyBase { }
        class MyClass : MyBase { }
        class Program
        {
            static void Main(string[] args)
            {
                MyClass c = new MyClass();
                new Program().Test(c);
            }

            public void Test(object obj)
            {
                //  as 연산자
                MyBase a = obj as MyBase;

                //  is 연산자
                bool ok = obj is MyBase;    //true;

                //  Explicit Casting
                MyBase b = (MyBase)obj;
            }
        }
    }
    #endregion
}
