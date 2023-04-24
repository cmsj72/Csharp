using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_접근_제한자
{
    #region 접근 제한자(Access Modifier)

    //  public : 모든 외부(파생 클래스 포함)에서 이 타입을 액세스 할 수 있다.
    //          (개별 타입 멤버의 액세스 권한은 해당 멤버의 접근 제헌자에 따라 별도로 제한될 수 있다)
    //  internal : 동일한 Assembly 내에 있는 다른 타입들이 액세스 할 수 있다. 하지만, 다른 어셈블리에서는 접근이 불가하다.
    //  protected : 파생클래스에서 이 클래스 멤버를 액세스할 수 있다.
    //  private : 동일 클래스/구조체 내의 멤버만 접근 가능하다.

    //  클래스 멤버는 5가지의 접근 제한자를 (public, internal, private, protected, protected internal) 모두 가질 수 있지만,
    //  구조체(struct) 멤버는 상속이 되지 않으므로 3가지의 접근 제한자만 (public, internal, private) 가질 수 있다.

    //  보통 클래스와 구조체는 네임스페이스 바로 밑에 선언하는데,이때 디폴트로 internal 접근 제한을 갖는다.
    //  단, 클래스 내부에 Nested 클래스를 선언하는 것과 같이 Nested Type을 선언하면 디폴트로 private 접근 제한을 갖는다.

    //  Nested 클래스 : 클래스 내부에서 클래스를 정의
    //  인터페이스(interface)와 열거형(enum)의 멤버는 기본적으로 public 이며, 각 멤버에 별도의 접근 제한자를 사용하지 않는다.
    #endregion

    #region 접근 제한자 사용
    //  클래스의 필드는 기본적으로 private으로 설정하여 외부로부터의 접근을 완전히 제한하는 것이 일반적(OOP 원칙에 따라)
    //  메서드는 외부에서 호출해야 하는 것은 public으로, 내부에서만 사용되는 것은 private으로 설정
    //  메서드는 이외에도 어셈블리 내부에서만 사용 가능한 internal, 파생클래스에서 액세스할 수 있는 protected 사용가능
    //  속성은 메서드와 동일한 방식으로 설정
    internal class MyClass
    {
        private int _id = 0;
        public string Name { get; set; }
        public void Run(int id) { }
        protected void Execute() { }
    }
    #endregion
}
