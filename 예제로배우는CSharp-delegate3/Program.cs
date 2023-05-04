using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 예제로배우는CSharp_delegate3
{
    #region Delegate에서 Event로
    //  모든 이벤트(event)는 특수한 형태의 delegate 이다.
    //  개발자가 한 컴포넌트에서 추가 연산(+=)을 사용 하지 않고 실수로 할당 연산자(=)를 사용하였다고
    //  가정하자. 이 할당연산은 기존에 가입된 모든 메서드 리스트를 지워버리고 마지막에 할당한 메서드 한개만
    //  InvocationList에 넣게 할 것이다. 즉, 누구든 할당 연산자를 한번 사용하면
    //  기존에 가입받은 모든 메서드 호출요구를 삭제하는 문제가 발생한다.

    //  또다른 중요한 문제점은 delegate는 해당 클래스 내부에서 뿐만 아니라,
    //  외부에서도 누구라도 메서드를 호출하듯 (접근 제한이 없다면) 해당 delegate를 호출할 수 있다는 점이다.
    namespace Delegate_To_Event
    {
        /*class Program
        {
            static void Main(string[] args)
            {
                area = new MyArea();

                area.MyClick += Area_Click;
                area.MyClick += AfterClick;

                area.Show();

                //  덮어쓰기 : MyClick은 Area_Click 메서드만 갖는다.
                area.MyClick = Area_Click;

                //  C# delegate는 클래스 외부에서 호출할 수 있다.
                //  C# event는 불가
                area.myClick(null);
            }
        }*/
    }
    #endregion

    #region C# Event의 특성
    namespace CSharp_Event_Trait
    {
        class MyArea : Form
        {
            public MyArea()
            {
                // 이 부분은 당분간 무시. (무명메서드 참조)
                // 예제를 테스트하기 위한 용도임.
                this.MouseClick += delegate { MyAreaClicked(); };
            }
                        
            public delegate void ClickEvent(object sender);

            //  event 필드
            public event ClickEvent MyClick;

            //  예제를 단순화 하기 위해
            //  MyArea가 클릭되면 아래 함수가 호출된다고 가정
            void MyAreaClicked()
            {
                if(MyClick != null)
                {
                    MyClick(this);
                }
            }
        }

        class Program
        {
            static MyArea area;

            static void Main(string[] args)
            {
                area = new MyArea();

                //  이벤트 가입
                area.MyClick += Area_Click;
                area.MyClick += AfterClick;

                //  이벤트 탈퇴
                area.MyClick -= Area_Click;

                //  Error : 이벤트 직접호출 불가
                //area.MyClick(this);

                area.ShowDialog();
            }

            static void Area_Click(object sender)
            {
                area.Text += " MyArea 클릭! ";
            }

            static void AfterClick(object sender)
            {
                area.Text += " AfterClick 클릭 ";
            }
        }
    }
    #endregion
}
