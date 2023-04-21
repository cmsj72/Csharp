#define TEST_ENV

#if(!ENTERPRISE_EDITION)
#warning This class should be used in Enterprise Edition
#endif

#define STANDARD_EDITION
#define ENTERPRISE_EDITION

#if(STANDARD_EDITION)
#error Use either STANDARD or ENTERPRISE edition;
#endif

#pragma warning disable 3021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_전처리기
{
    #region C# 전처리기 지시어 (Preprocessor Directive)
    //  실제 컴파일이 시작되기 전에 컴파일러에게 특별한 명령을 미리
    //  처리하도록 지시하는 것. 모든 C# 전처리기 지시어는 # 으로 시작되며
    //  한 라인에 한 개의 전처리기 명령만을 사용
    //  전처리기 지시어는 C# Statement가 아니기 때문에 세미콜론을 붙이지 않는다.

    //  전처리기 지시어는 해당 파일 안에서만 효력을 발생
    //  만약 하나의 클래스가 두개의 파일에 나눠 Partial Class로 저장되었을 때,
    //  두개의 파일에서 동일한 심벌(#define으로 정의)을 사용하고 싶으면, 두개의 파일에 
    //  각각 심벌을 정의해야 한다.
    //  C# 전처리기는 C/C++와 달리 별도의 Preprocessor를 갖기 않고 컴파일러가
    //  Preprocessor Directive를 함께 처리
    #endregion

    #region 조건별 컴파일
    //  #define, #if ... #else ... #endif
    //  #define은 심벌을 정의할 때 사용, 예를 들어 #define DEBUG 혹은 #define RELEASE
    //  와 같이 하나의 심벌을 정의. 이렇게 정의된 심벌은 다른 전처리기 지시어에서 사용된다.
    //  예를 들어 #if (DEBUG)와 같이 if 지시어에서 사용될 수 있다.

    //  #define과 #if를 결합하여 조건별로 서로 다른 코드 블럭을 컴파일하도록 할 수 있다.
    /*class Program
    {        
        static void Main(string[] args)
        {
            bool verbose = false;

#if (TEST_ENV)
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#else
            Console.WriteLine("Production");
#endif
            if (verbose)
            {

            }
        }
    }*/
    #endregion

    #region 전처리기 지시어
    //  #region은 코드 블럭을 논리적으로 묶을 때 유용.
    //  #region은 #endregion과 쌍을 이루며 한 영역을 형성
    //  #region 안에 다른 Nested Region을 둘 수도 있다.
    //  복잫바고 긴 클래스를 개념적으로 묶을 때 매우 유용
    class ClassA
    {
        #region Public Methods
        public void Run() { }
        public void Create() { }
        #endregion

        #region Public Properties
        public int Id { get; set; }
        #endregion

        #region Privates
        private void Execute() { }
        #endregion
    }
    #endregion

    #region 기타 전처리기 지시어
    //  #undef  #define과 반대로 지정된 심벌을 해제 할 때 사용
    //  #elif   #if와 함께 사용하여 else if를 나타낸다.
    //  #line   거의 사용되지 않음. 라인번호를 임의로 변경하거나 파일명을 임의로 다르게 설정 가능하게 해줌
    //  #error  전처리시 Preprocessing을 중단하고 에러 메시지를 출력하게 함
    //  #warning 경고 메세지를 출력하지만 Preprocessing은 계속 진행
    //  warning과 error는 특정 컴포넌트가 어떤 환경에서 실행되지 않아야 할 때
    //  이를 경고나 에러를 통해 알리고자 할 때 사용될 수 있음

    namespace App1
    {
        class EnterpriseUtility { }
    }

    namespace App1
    {
        class Class1 { }
    }
    #endregion

    #region #pragma 전처리기 지시어
    //  #pragma 지시어는 위의 표준 C# 전처리기 지시어와 다르게, 컴파일러 제작업체가 고유하게
    //  자신들의 것을 만들어 사용할 수 있는 지시어.
    //  어떤 컴파일러를 쓰느냐에 따라 지원되는 #pragma가 서로 다르며, 개발자가 임의로 지정하여 사용할 수 없다.

    //  MS의 C# 컴파일러는 현재 #pragma warnin과 #pragma checksum 2개를 지원
    //  #prama warning는 경고메서지를 Disable/enable 하게 할 수 있으며,
    //  #pragma checksum는 주로 ASP.NET 페이지 디버깅을 위해 만들어진 것으로 ASPX 페이지의 파일 체크섬을 생성할 때 사용
    namespace App1
    {
        [System.CLSCompliant(false)]
        class Program
        {
            static void Main(string[] args)
            {
#pragma warning disable
                if (false)
                {
                    Console.WriteLine("TBD");
                }
#pragma warning restore
            }
        }
    }
    #endregion
}
