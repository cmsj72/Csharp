﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 예제로배우는CSharp
{
    #region Nullable Type
    /*class Program
    {
        static void Main(string[] args)
        {
            
            //  Nullable Type
            //  정수(int)나 날짜(DateTime)과 같은 Value Type은 일반적으로 NULL을 가질 수 없다.
            //  C# 2.0에서부터 이러한 타입들에게 NULL을 가질 수 있게 함, 이를 Nullable Type이라 부른다.
            int? i = null;
            i = 101;

            bool? b = null;

            //  int? 혹은 DateTime? 같이 하면 Nullable Type이 된다. 
            //  이는 컴파일하면 .NET의 Nullable<T> 타입으로 변환된다. 
            //  Nullable Type (예: int?) 을 일반 Value Type (예: int)으로 변경하기 위해서는 Nullable의 .Value 속성을 사용한다.
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
            int? i2 = null;
            //  ?? 연산자는 ?? 왼쪽 피연산자의 값이 NULL인 경우 ?? 뒤의 피연산자 값을 리턴하고, 아니면 그냥 ?? 앞의 피연산자 값을 리턴한다. 
            //  ?? 연산자는 왼쪽 피연산자가 NULL이 허용되는 데이타 타입인 경우에만 사용된다.
            int a = i2 ?? 100;
            Console.WriteLine(a);
            
        }
    }*/
    #endregion

    #region Constant
    /*class CSVar
    {
        //  const
        //  필드 선언부에서 사용되거나 메서드 내에서 사용될 수 있으며,
        //  컴파일시 상수값이 결정
        const int MAX_VALUE = 1024;

        //  읽기전용(개념적으로 상수와 비슷한)필드
        //  필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있고,
        //  런타임시 값이 결정된다.
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }

        static void Main(string[] args)
        {

        }
    }*/
    #endregion

    #region Array
    /*class CSharpArray
    {
        static void Main(string[] args)
        {
            //  1차원 배열
            string[] players = new string[10];
            string[] Regions = { "서울", "경기", "부산" };

            //  2차원 배열
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            //  3차원 배열
            string[,,] Cubes;

            //  가변 배열(Jagged Array)
            //  1차 배열 크기(3)은 명시 해야한다
            int[][] A = new int[3][];
            int[][] B;
            int size = 10;

            //  각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 4, 5, 6, 7 };

            A[0][0] = 1;
            A[0][1] = 2;

            //  모든 C# 배열은 내부적으로 .NET Framework의 System.Array에서 파생된 것
            //  System.Array의 메서드, 프로퍼티를 사용할 수 있다.

            //  배열은 레퍼런스(Reference)타입
            //  다른 객체나 메서드에 전달할 때 직접 모든 배열 데이터를 복사하지 않고
            //  배열 전체를 가리키는 참조 값(Reference pointer)만을 전달
            int[] score = { 70, 80, 90, 100 };
            change(score);
        }

        static void change(int[] arr)
        {
            int tmp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = tmp;
        }
    }*/
    #endregion

    #region String
    /*class CSharpString
    {
        static void Main(string[] args)
        {
            //  string은 .NEY의 System.String 클래스와 동일
            //  System.String 클래스의 모든 메서드와 속성 사용 가능
            //  C# 문자열은 Immutable, 즉 한번 문자열이 설정되면, 다시 변경할 수 없다.
            //  (한번 그 값이 설정되면 다시 변경할 수 없는 타입을 Immutable Type,
            //   반대로 값을 계속 변경할 수 있는 것을 Mutable Type)
            //  s = "C#"; 이라고 한 후 다시 s = "F#"; 이라고 실행하면,
            //  .NET 시스템은 새로운 string 객체를 생성하여 "F#"이라는 데이타로 초기화 한 후 이를 변수명 s 에 할당한다.
            //  변수 s 는 내부적으로는 전혀 다른 메모리를 갖는 객체를 가리키는 것
            string s1 = "C#";
            string s2 = "Programming";
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            //  StringBuilder는 System.Text.StringBuilder 클래스
            //  String은 Immutable Type이기 때문에 문자열 갱신을 많이 하는 프로그램에서는 적당하지 않다
            //  StringBuilder는 Mutable Type 이기 때문에 문자열 갱신이 많은 곳에서 자주 사용
            //  일정한 버퍼를 갖고 문자열 갱신을 효율적으로 처리하기 때문
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
                //sb.Append("\n");
            }
            string s = sb.ToString();

            Console.WriteLine(s);
        }
    }*/
    #endregion

    #region enum
    /*class CSharpEnum
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }
        static void Main(string[] args)
        {
            //  enum은 열거형 상수(constant)를 표현하기 위한 것,
            //  상수 숫자들을 보다 의미있는 단어들로 표현

            //  플래그(flag) enum
            //  enum의 각 멤버들은 각 비트별로 구분되는 값들(1,2,4,8...)을 가질 수 있다.
            //  이렇게 enum 타입이 비트 필드를 갖는다는 것을 표시하기 위해 enum 선언문 바로 위에
            //  [Flags]라는 Attribute (Type 혹은 그 멤버를 선언할 때 그 위에 붙이는 특별한 특성값으로
            //  해당 타입 혹은 멤버가 어떤 특성을 갖고 있는지 나타내게 된다)

            //  [Flags] 특성을 갖는 플래그 enum은 OR 연산자를 이용해서 한 enum 변수에 다중값(예: 1+4)을 가질 수 있으며,
            //  AND 연산자를 이용하여 enum 변수가 특정 멤버를 포함하고 있는지 체크할 수 있다.
            
            //  OR 연산자로 다중 플래그 할당
            Border b = Border.Top | Border.Bottom;

            //  & 연산자로 플래그 체크
            if((b & Border.Top) != 0)
            {
                if (b.HasFlag(Border.Bottom))
                {
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }*/
    #endregion

    #region foreach
    /*class Foreach
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "AB", "CD", "EF" };

            //  foreach 루프
            foreach(string s in array)
            {
                Console.WriteLine(s);
            }

            //  for vs foreach
            //  성능적 측면은 for가 경우에 따라 약간 빠를 수 있지만 대부분의 경우 성능적 차이는 크지 않으며,
            //  foreach는 for보다 훨신 간결한 코드를 제공한다는 장점이 있다.
            //  루프에서 가장 많이 사용되는 C# 배열(array)의 경우,
            //  foreach가 내부적인 최적화를 거쳐 for 루프와 동일한 성능이므로 더 간결한 foreach를 사용할 것을 권장
            string[,,] arr = new string[,,] {
                    { {"1", "2"}, {"11","22"} },
                    { {"3", "4"}, {"33", "44"} }
            };

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[i,j,k]);
                    }
                }
            }

            //  3차원 배열의 요소를 모두 처리
            foreach(var s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }*/
    #endregion

    #region yield
    /*class Yield
    {
        static void Main(string[] args)
        {
            //  C#의 yield 키워드는 호출자(Caller)에게 콜렉션 데이터를 하나씩 리턴할 때 사용
            //  Enumerator(Iterator)라고 불리우는 이러한 기능은 집합적인 데이터셋으로부터 데이터를 하나씩
            //  호출자에게 보내주는 역할을 한다.

            //  yield는 yield return 또는 yield break의 2가지 방식으로 사용
            //  (1) yield return은 컬렉션 데이터를 하나씩 리턴하는데 사용
            //  (2) yield break는 리턴을 중지하고 Iteration루프를 빠져 나올 때 사용

            //  다음 내용은 C#고급 문법에 가깝고 분량이 많기 때문에
            //  https://www.csharpstudy.com/CSharp/CSharp-yield.aspx
            foreach (int num in GetNumber()){
                Console.WriteLine(num);
            }
        }

        static IEnumerable<int> GetNumber()
        {
            yield return 10;//  첫번째 루프에서 리턴되는 값
            yield return 20;//  두번째 루프에서 리턴되는 값
            yield return 30;//  세번째 루프에서 리턴되는 값
        }
    }*/
    #endregion

    #region Exception 예외 처리
    /*class CSharpException
    {
        //  C#을 포함한 모든 .NET 프로그래밍 언어는 .NET Framework의 Exception 메카니즘에 따라 
        //  Exception을 처리
        //  .NET의 System.Exception은 모든 Exception의 Base 클래스이며, 예외 처리는 이 Exception객체를 기본으로 처리
        //  만약 Exception이 발생했는데 이를 프로그램 내에서 처리하지 않으면(Unhandled Exception)
        //  프로그램은 충돌(Crash)하여 종료

        //  모든 Exception을 잡고 싶을 때는 catch{...} 또는 catch(Exception ex){...} 처럼
        //  모든 Exception의 베이스 클래스인 System.Exception를 잡으면 된다.
        //  특정 Exception을 잡기 위해서는 해당 Exception Type을 catch

        //  catch 블럭은 하나 혹은 여러개 일 수 있다.
        //  각 Exception 유형에 따라 서로 다른 에러 핸들링을 하기 위해

        //  finally는 Exception의 발생 유무와 관계없이 마지막에 반드시 실행되는 블럭

        //  C# throw 
        //  try 블럭에서 Exception이 발생했는데 이를 catch 문에서 잡았다면, 
        //  Exception은 이미 처리된 것으로 간주
        //  catch문에서 기존의 Exception을 다시 상위 호출자로 보내고 싶을 때 throw 사용

        //  throw를 쓰는 경우
        //  (1)throw문 다음에 catch에서 전달받은 Exception 객체를 쓰는 경우
        //      throw ex; 와 같이 catch (Exception ex) 에서 전달받은 아규먼트 ex 를 사용하는 경우
        //      ex 에 담긴 예외 정보를 보전하지만, Stack Trace 정보를 다시 리셋하기 때문에 throw문 이전의 콜스택(Call Stack) 정보를 유실하게 된다.
        //      따라서, 일반적으로 이러한 방식은 사용하지 않는 것이 좋다.
        //  (2)throw문 다음에 새 Exception객체를 생성해 전달하는 경우
        //      new를 사용하여 새로운 Exception 객체를 만든 후, 이 객체를 throw
        //      catch 에서 잡은 Exception을 Wrapping 하여 새로운 Exception을 전달할 때 사용하는데,
        //      잘못 사용하면(InnerException을 포함하지 않으면) 기존 Exception 정보를 잃을 수 있다.
        //      새로운 Exception 객체를 만들 때는 catch 에서 얻은 Exception 객체를
        //      새 객체의 InnerException에 포함시켜 에러 정보를 보전하는 것이 좋다.
        //  (3)throw문 다음에 아무것도 없는 경우(throw;)
        //      catch문에서 잡힌 Exception을 그대로 상위 호출 함수에게 전달하는 일(rethrow)을 한다.
        //      에러를 발생시킨 콜스택 정보를 그대로 상위 호출 함수에 전달하려면 이렇게 throw; 를 호출하면 된다.
        //      throw; 는 에러가 다른 메서드에서 발생했을 때는 그 에러가 발생한 다른 메서드의 위치를 포함하지만,
        //      만약 throw문과 동일한 메서드에서 에러가 발생했다면 동일 메서드의 어느 라인에서 에러가 발생했는지는 포함하지 않는다.
        static void Main(string[] args)
        {
            try
            {
                // 실행하조자 하는 내용
            }
            catch(Exception ex)
            {
                //  에러 처리 / 로깅(Logging) 등
                throw;
            }

            try { }
            catch (ArgumentException ex) { }
            catch (AccessViolationException ex) { }
            finally { }

            string connStr = "Data Source=(local);Integrated Security=true;";
            string sql = "SELECT COUNT(1) FROM sys.objects";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }*/
    #endregion

    #region 구조체
    /*class CSharpStruct
    {
        //  Value Type vs Reference Type
        //  C#에서는 struct를 사용하면 Value Type을 만들고, class를 사용하면 Reference Type을 만든다

        //  C# .NET의 기본 데이터형들은 struct로 정의, 모두 Value Type이다. 
        //  Value Type은 상속될 수 없으며, 상대적으로 간단한 데이터 값을 저장하는데 사용

        //  Reference Type은 class를 정의하여 만들며 상속이 가능

        //  Value Type의 파라미터 전달은 데이터를 복사(copy)하여 전달, 
        //  Reference Type은 Heap 상의 객체에 대한 레퍼런스(reference)를 전달하여 이루어짐

        //  C#의 구조체는 클래스와 같이 메서드, 프로퍼티 등 거의 비슷한 구조를 가지고 있지만, 상속은 불가능
        //  C# 구조체가 상속은 할 수는 없어도, 클래스와 마찬가지로 인터페이스 구현 가능
        
        struct MyPoint
        {
            public int X;
            public int Y;
            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }
        }

        static void Main(string[] args)
        {
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }*/
    #endregion

    #region 클래스
    /*class Classs
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
    }*/

    /*public class MyCustomer
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
                if(this.name != value)
                {
                    this.name = value;
                    if(NameChanged != null)
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
    }*/

    #endregion

    #region 메서드
    class Method
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
        static void Calc(params int[] values)
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
        }
        #endregion
    }
    #endregion
}
