#### GDI

------

- GDI & GDI+

  - GDI(Graphics Device Interface) → OS의 영역
  - GDI+ → .NET은 Graphics가 담당

- Graphics 사용 방법 2가지

  - paint() 이벤트
    - e.Graphics()
  - CreateGraphics() 사용
    - Graphics 참조 변수 생성

- CreateGraphics()

  - 언제 사용?

    - paint 이벤트 외의 메서드

  - 원형

    ```c#
    public Graphics CreateGraphics()
    // namespace → System.Windows.Forms
    // 사용한 후에는 되도록 Graphics.Dispose() 호출	
    ```

  - 사용하는 방법

    - Graphics 객체를 참조
    - Graphics 메서드로 출력





#### Color

------

- 사용 용도

  - 펜, 브러시의 색상 설정에 사용

- Color 속성 사용하여 색상 설정

  - AliceBlue, AntiquWhite, Aqua 등 속성을 통한 색상 설정, Color 리턴

- 사용자 정의할 수 있는 색상

  ```
  FromArgb()
  FromArgb(int alpha, int red, int green, int blue);
  ```

- 시스템 색상에서 A, R, G, B 가져오기→ Color.색상.A, Color.색상.R, Color.색상.G, Color.색상.B





#### Pen

------

- Pen vs Pens

  - Pen→생성
  - Pens→기본 제공 펜

- Pen 생성자

  - Pen(Brush), Pen(Color), Pen(Brush, Single), Pen(Color, Single)

- Pen 해제

  - Dispose()

- 펜 스타일

  - DashStyle 속성 사용

    ```c#
    public System.Drawing.Drawing2D.DashStyle DashStyle{get;set;}
    ```

  - using System.Drawing.Drawing2D 선언

  - DashStyle 열거형 리턴

    - Custom, Dash, DashDot, DashDotDot, Dot, Solid





#### Brush

------

- 역할
  - 도형 내부를 색 또는 패터능로 채우는 역할
- 브러시 종류
  - SolidBrush, HatchBrush, TextureBrush... 등
- 브러시를 요구하는 메서드의 공통점
  - Fill~~~로 시작
- SolidBrush 단색 브러시
  - 도형 전체를 한가지 색으로 채우는 브러시
- HatchBrush 패턴 브러시
  - 격자 패턴으로 도형을 채우는 브러시
  - using System.Drawing.Drawing2D;