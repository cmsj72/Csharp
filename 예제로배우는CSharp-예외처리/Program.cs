using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 예제로배우는CSharp_예외처리
{
    class Program
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
            catch (Exception ex)
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
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
