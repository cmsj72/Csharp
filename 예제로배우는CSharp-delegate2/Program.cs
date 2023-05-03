using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 예제로배우는CSharp_delegate2
{
    #region C# delegate 필드와 delegate 속성
    //  delegate는 클래스의 필드나 속성에 사용될 수 있다.
    namespace Delegate_Field_AND_Property
    {
        class MyArea : Form
        {
            public MyArea()
            {
                // 이 부분은 당분간 무시 (무명메서드 참조)
                // 예제를 테스트하기 위한 용도임.
                this.MouseClick += delegate { MyAreaClicked(); };
            }

            public delegate void ClickDelegate(object sender);

            //  Delegate 필드
            public ClickDelegate MyClick;

            // 필드 대신 Delegate 속성으로도 가능
            //public ClickDelegate Click { get; set; }


            void MyAreaClicked()
            {
                if (MyClick != null)
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
                area.MyClick = Area_Click;
                area.ShowDialog();
            }

            static void Area_Click(object sender)
            {
                area.Text = "MyArea 클릭!";
            }
        }

        //  MyClick 필드는 area.MyClick = Area_Click; 라는 할당 연산자 문장이 실행되어
        //  하나의 메서드 레퍼런스만을 가진다. 만약 다른 메서드를 이 필드(혹은 속성)에 할당 연산자(=)를 써서 다시 할당하면,
        //  필드에는 기존 메서드 정보는 지우고 가장 최근에 할당한 메서드만 저장하게 된다.

        //  C# delegate는 할당 연산자(=) 대신 += Operator를 사용하면
        //  델리게이트 객체 내에 여러 메서드들에 대한 리스트 정보를 가지게 된다.
    }
    #endregion

    #region C# Multicast Delegate
    //  C# delegate는 여러 개의 메서드들을 할당하는 것이 가능하다.
    //  C# 연산자 +=을 사용하면 메서드를 계속 delegate에 추가하게 되는데,
    //  내부적으로는 .NET MulticastDeleagate 클래스에서 이 메서드들의 리스트
    //  (이를 InvocationList라 한다)를 관리하게 된다.

    //  복수개의 메서드들이 한 delegate에 할당되면, 이 delegate가 실행될 때,
    //  InvocationList로부터 순서대로 메서드를 하나씩 실행
    namespace Multicast_Delegate
    {
        static MyArea area;

        static void Main(string[] args)
        {
            area = new MyArea();

            //  복수개의 메서드를 delegate에 할당
            area.MyClick += Area_Click;
            area.MyClick += AfterClick;

            area.ShowDialog();
        }

        static void Area_Click(object sender)
        {
            area.Text += " MyArea 클릭! ";
        }

        static void AfterClick(object sender)
        {
            area.Text += " AfterClick 클릭! ";
        }
    }

    #endregion
}
