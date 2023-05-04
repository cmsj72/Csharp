using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 예제로배우는CSharp_무명_메서드
{
    #region C# 무명 메서드(Anonymous Method)
    //  C# 2.0에서부터 메서드를 미리 정의하지 않아도 되는 메서드명이 없는 
    //  무명 메서드(혹은 익명 메서드, Anonymous Method)를 지원
    //  만약 어떤 메서드가 일회용으로 단순한 문장들로 구성되어 있다면, 굳이 별도의 메서드를 정의하지 않아도 된다
    
    //  delegate 키워드와 함께 파라미터와 실행 문장 블럭을 적으면 된다.
    //  delegate 뒤의 파라미터는 해당 메서드 원형(Prototype)에 맞는 동일한 파라미터 타입이어야 하며,
    //  실행 문장블럭에는 여러 문장들을 쓸 수 있다.
    //  무명 메서드는 외관상 인라인 메서드 형식을 띠며,
    //  무명 메서드 자체를 delegate 타입의 변수에 할당할 수도 있다.

    /*namespace Anonymous_Method
    {
        class Program
        {
            delegate void MyDelegate(int a);

            
            static void Main(string[] args)
            {
                //  무명메서드 형식: delegate(파라미터들) { 실행문장들};
                MyDelegate d = delegate (int p)
                {
                    Console.Write(p);
                };

                d(100);
            }

        }
    }*/
    #endregion

    #region C# 무명 메서드 사용
    //  C# 무명 메서드를 사용하기 위해서는 메서드가 필요한 곳에 직업 delegate로
    //  시작하는 무명 메서드를 써주면 된다.
    //  ex) 무명 메서드를 델리게이트 변수에 할당해서 사용, 메서드의 파라미터에 인라인 형식으로 무명 메서드를 사용,
    //      이벤트 핸들러를 추가하는 곳에 무명 메서드를 사용

    namespace AnonymouseMethod_Use
    {
        /*public partial class Form1 : Form
        {
            public Form1()
            {
                this.InitializeComponent();

                //  메서드명을 지정
                this.button1.Click += new System.EventHandler(this.button1_Click);
                
                //  무명메서드를 지정
                this.button2.Click += delegate (object s, EventArgs e)
                {
                    MessageBox.Show("버튼2 클릭");
                };
            }
            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("버튼1 클릭");
            }
        }*/

        class MyClass
        {
            public event EventHandler eventHandler;

            public MyClass()
            {
                eventHandler += new EventHandler(func);
                eventHandler += delegate (object s, EventArgs e)
                {
                    Console.WriteLine("무명 메서드를 사용한 이벤트 추가된거");
                };
            }
            void func(object sender, EventArgs e)
            {
                Console.WriteLine("func 실행");
            }

            public void eventActivate()
            {
                eventHandler(this, EventArgs.Empty);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyClass myClass = new MyClass();
                myClass.eventActivate();
            }
        }
        
    }
    #endregion

    #region 델리게이트 타입 vs 무명 메서드(1)
    //  
    #endregion
}
