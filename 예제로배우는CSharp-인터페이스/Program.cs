using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace 예제로배우는CSharp_인터페이스
{
    #region C# 인터페이스
    //  클래스와 비슷하게 인터페이스는 메서드, 속성, 이벤트, 인덱서 등을 갖지만
    //  인터페이스는 이를 직접 구현하지 않고 단지 정의(property definition)만을 갖는다.
    //  추상 멤버(abstract member)로 구성된 추상 Base클래스(abstract class)와 개념적으로 유사
    //  클래스가 인터페이스를 가지는 경우 해당 인터페이스의 모든 멤버에 대한 
    //  구현(implementation)을 제공해야 함

    //  한 클래스는 하나의 Base 클래스만을 가질 수 있지만, 인터페이스는 여러 개를 가질 수 있다.
    namespace CSharp_Interface
    {
        interface Component { }
        interface IDbConnection { }
        public class MyConnection : Component, IDbConnection, IDisposable
        {
            //  IDbConnection을 구현
            //  IDisposable을 구현
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
    #endregion

    #region C# 인터페이스 정의
    //  인터페이스는 C# 키워드 interface를 사용하여 정의
    //  인터페이스 정의 시에는 (메서드와 같은) 내부 멤버들에 대해 접근 제한자를 사용하지 않는다.
    namespace Interface_Definition
    {
        public interface IComparable
        {
            //  멤버 앞에 접근제한자 사용 안함
            int CompareTo(object obj);
        }
    }
    #endregion

    #region C# 인터페이스의 구현
    //  C# 클래스가 인터페이스를 갖는 경우 인터페이스의 모든 멤버에 대한 구현을 제공해야 한다.
    //  C#에서는 인터페이스로부터 직접 new를 사용하여 객체를 생성할 수 없다.

    namespace Interface_Implementaion
    {
        public class MyClass : IComparable
        {
            private int key;
            private int value;

            //  IComparable 의 CompareTo 메서드 구현
            public int CompareTo(object obj)
            {
                MyClass target = (MyClass)obj;
                return this.key.CompareTo(target.key);
            }
        }
    }
    #endregion

    #region C# 인터페이스의 사용
    //  C# 실무에서 클래스와 인터페이스를 잘 정의하고 사용하는 것은 매우 중요
    //  비지니스를 객체지향 프로그래밍으로 디자인하고 구현하는데 가장 중요한 핵심이기 때문
    //  .NET Framework도 상당히 많은 인터페이스를 구현, 거의 모든 영역에서 흔히 사용
    namespace Interface_Implementation
    {
        class Progam
        {
            public void Run()
            {
                // 인터페이스 사용하기 때문에
                // 특정 DB Connection을 신경 쓸 필요가 없다
                IDbConnection dbCon = GetDbConnection();
                dbCon.Open();
                if (dbCon.State == ConnectionState.Open)
                {
                    dbCon.Close();
                }
            }

            // IDbConnection 인터페이스를 리턴
            public IDbConnection GetDbConnection()
            {
                IDbConnection dbConn = null;
                string cn = ConfigurationManager.AppSettings["Connection"];
                switch (ConfigurationManager.AppSettings["DbType"])
                {
                    case "SQLServer":
                        dbConn = new SqlConnection(cn);
                        break;
                    case "Oracle":
                        dbConn = new OracleConnection(cn);
                        break;
                    case "OleDB":
                        dbConn = new OleDbConnection(cn);
                        break;
                }
                return dbConn;
            }
        }
    }
    #endregion

}
