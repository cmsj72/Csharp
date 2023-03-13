using System;
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
            //  Enumerator(Iterator)라고 불리우는 이러한 기능은 집합ㅈ거인 데이터셋으로부터 데이터를 하나씩
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
    class CSharpException
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
    }
    #endregion
}
