## C#

- C++ 언어 기반 + java 장점 = C# 언어
- C# 언어의 사용범위 : XML, Web, Network, 데이터베이스, 게임, IoT 등...
- C#은 포인터를 사용하지 않는다.
  - 메모리 관리자?
  - 객체 생성 new → 해제?
  - 가비지 컬렉터(Garbage Collector)
- C#프로그램 실행
  1. C#언어→컴파일(Visual Studio)
  2. MSIL(*.exe 결과물)
  3. CLR
  4. 실행




## 클래스 라이브러리

- C#언어 + 클래스 라이브러리 = C# 프로그래밍
- MSDN을 참고([msdn.Microsoft.com]())
- 클래스 라이브러리
  - BCL(Basic Class Library): 기본 클래스
  - Window Form: 윈도우 응용 프로그램 제작을 위한 클래스 라이브러리
  - ASP.NET: 웹 클래스 라이브러리
  - ADO.NET: 데이터베이스 클래스 라이브러리



## CLR(Common Language Runtime)

- 역할 : 컴파일된 C# 코드를 실행하는 역할(*.exe 파일)
- MSIL, IL(Intermediate Language), 중간 언어
  - *.exe 파일을 읽어서 OS에 맞게 다시 컴파일해서 실행
  - Visual Studio에서 C# 코드를 컴파일한 코드
  - *.exe, *.dll (어셈블리, assembly)
  - 닷넷 언어인 VB, C# 등의 공통 언어



## CTS(Common Type System) 와 CLS(Common Language Specification)

- CTS는 공통 데이터형과 형식정의
  - int→ System.Int32
  - float→System.Single
- CLS는 공통 언어 사양 정의
  - 닷넷 언어가 지켜야 할 최소 코드 규칙