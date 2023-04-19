using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_클래스
{
    class Program
    {
        //  C# class 키워드는 Reference Type을 정의하는데 사용
        //  메서드, 속성, 필드, 이벤트 등을 멤버로 포함하는 소프트웨어 단위
        //  보통 이 클래스 정의로부터 객체(Object)를 생성해 사용
        //  클래스를 정의할 때 중요한 멤버는 공용(public) 메서드와 속성인데,
        //  이 public 멤버들은 외부 객체와의 상호작용을 위해 사용

        #region 클래스 멤버 종류
        //  메서드(Method): 클래스에서 실제 행동을 일으키는 코드 블럭
        //  속성(Property):  클래스의 내부 데이터를 외부에서 사용할 수 있게 하거나
        //                  외부에서 클래스의 내부 데이터를 간단하게 설정할 때 사용
        //  필드(Field): 클래스의 내부 데이터는 필드에 저장, 필드들은 객체의 상태를 유지하는데 이용
        //              클래스는 동일하더라도 다른 필드 값을 가짐에 따라 서로 다른 객체 상태를 가짐
        //  이벤트(Event): 이벤트는 객체 내부의 특정 상태를, 혹은 어떤 일이 일어났다는 이벤트를 외부로 전달하는데 이용
        //                예를 들어 Button 클래스의 경우 버튼이 클릭되면, 버튼 클릭 이벤트에 가입한 모든 외부 객체들에게
        //                그 사실(이벤트)을 통보하게 된다.
        #endregion

        //  Partial 클래스
        //  C# 2.0 부터 도입, 하나의 클래스를 2개 이상의 파일에 나누어 정의할 수 있는 기능
        //  Visual Studio에서 Windows Form을 만들면 자동으로 동일 클래스를 2개의 파일에 나누어 저장한다.
        //  예를 들어, Form1을 생성하면 Form1.cs와 Form1.designer.cs 파일이 생성된다. 이러한 2개 파일에 동일한 클래스의 필드, 메서드, 속성 등을 나누어 저장하기 위해 partial class를 이용한다.
        //  Partial 클래스를 정의하기 위해서는 C# 키워드 partial을 class 앞에 써주면 된다. (좀 더 자세한 내용은 C#의 partial 키워드 설명을 참조)
        //  ex) public partial class Form1{...}
        static void Main(string[] args)
        {

        }
    }

    public class MyCustomer
    {
        //  public class 이므로 모든 객체로부터 접근 가능,
        //  만약 internal class 이면 해당 어셈블리 내에서만 접근 가능

        //  필드
        private string name;
        private int age;

        //  이벤트
        public event EventHandler NameChanged;

        //  생성자 (Constructor)
        //  클래스로부터 객체가 만들어 질때 호출, 주로 필드를 초기화 하는데 사용
        public MyCustomer()
        {
            name = string.Empty;
            age = -1;
        }

        //  속성
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        //  메서드
        public string GetCustomerData()
        {
            string data = string.Format("Name: {0} (Age: {1}",
                this.Name, this.Age);
            return data;
        }
    }
}
