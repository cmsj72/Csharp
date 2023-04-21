using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_event
{
    #region C# 이벤트
    //  이벤트
    //  클래스내에 특정한 일(event)이 일어났음을 외부에 이벤트 가입자(subscriber)들에게 알려주는 기능
    //  event라는 키워드를 사용하여 표시, 클래스 내에서 일종의 필드처럼 정의된다.

    //  이벤트에 가입하는 외부 가입자 측에서는 이벤트가 발생했을 때 어떤 명령들을 실행할 지를 지정해 주는데,
    //  이를 이벤트 핸들러라 한다. 이벤트에 가입하기 위해서는 += 연산자를 사용하여 이벤트핸들러를 이벤트에 추가한다.
    //  반대로 이벤트핸들러를 삭제하기 위해서는 -= 연산자를 사용한다.
    //  하나의 이벤트에는 여러 개의 이벤트핸들러들을 추가할 수 있으며,
    //  이벤트가 발생되면 추가된 이벤트핸들러들을 모두 차례로 호출한다.

    class MyButton
    {
        public string Text;
        //  이벤트 정의
        public event EventHandler Click;

        public void MouseButtonDown()
        {
            if(this.Click != null)
            {
                //  이벤트핸들러를 호출
                Click(this, EventArgs.Empty);
            }
        }

        //  이벤트 사용
        public void Run()
        {
            MyButton btn = new MyButton();
            //  Click 이벤트에 대한 이벤트 핸들러로
            //  btn_Click 이라는 메서드를 지정함
            btn.Click += new EventHandler(btn_Click);
            btn.Text = "Run";
        }

        void btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button 클릭");
            Console.WriteLine("Button 클릭");
        }
        //  이벤트 Click은 외부에서 엑세스할 수 있게 public 필드로 정의되어 있다.
        //  MouseButtonDown() 메소드에서 이벤트를 외부로 보내기 전에 이벤트에 가입한 가입자들이 있는지 체크하기 위해 if (Click != null)을 사용한다.
        //  이벤트에 가입하거나 탈퇴하기 위해서는 += (subscribe) 또는 -= (unsubscribe) 연산자를 사용한다.
        //  여기서 void btn_Click(object sender, EventArgs e) 메서드는 이벤트핸들러로 사용되고 있다.
    }
    #endregion

    #region 이벤트: add와 remove
    //  C# 클래스의 속성(Property)에서 get, set 을 사용하듯이 event 에서는 add, remove 를 사용할 수 있다.
    //  속성의 get, set에서 값을 대입하거나 리턴하는 일 이외에
    //  간단한 체크 코드를 실행하는 것처럼 event 의 add, remove문에서도 이러한 코드를 넣을 수 있다.
    //  아래 예제에서, add문은 +=를, remove문은 -=을 사용하고 있는데,
    //  이는 _click 이벤트 안에 있는 내부 리스트에(주: 이를 InvoactionList라 하고
    //  _click.GetInvocationList()를 사용해서 리스트를 얻을 수 있다) value 델리게이트를 추가하거나
    //  삭제하는 기능을 한다. 여러 개의 델리게이트를 가지고 순서대로 호출하는 것을 
    //  멀티캐스트(Multicast) 델리게이트라 하는데, 델리게이트는 멀티캐스트를 디폴트(기본값)으로 한다.

    //  만약 add 문에서 +- 대신 = 를 사용하면 이는 기존 InvocationList의 내용을 지우고
    //  할당된 새 value 델리게이트 하나만 추가하게 된다.
    //  이는 특별한 용도로 Singlecast를 구현할 때 사용한다.
    class MyButton2
    {
        //  이벤트를 정의하는 다른 방법
        private EventHandler _click;
        public event EventHandler Click
        {
            add
            {
                _click += value;
                //  _click = value; // 싱글캐스트
            }
            remove
            {
                _click -= value;
            }
        }

        public void MouseButtonDown()
        {
            if(this._click != null)
            {
                //  이벤트핸들러들을 호출
                _click(this, EventArgs.Empty);
            }
        }
    }
    #endregion

    class CSharp_Event
    {
        static void Main(string[] args)
        {
            MyButton2 btn = new MyButton2();
            Message msg = new Message();
            btn.Click += new EventHandler(msg.func);
        }
    }

    class Message
    {
        //  object , EventArgs 파라미터가 있어야한다.
        public void func(object sender, EventArgs e)
        {
            Console.WriteLine("호출");
        }
    }


}
