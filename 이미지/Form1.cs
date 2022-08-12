using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이미지
{
    public partial class Form1 : Form
    {
        //  비트맵 세트 1
        Bitmap bitmap;

        //  더블 버퍼링 세트 1
        BufferedGraphicsContext context;
        BufferedGraphics graphics;
        Image myImage;

        public Form1()
        {
            InitializeComponent();

            //  비트맵 세트 1
            /*bitmap = new Bitmap(400, 300);
            SetClientSizeCore(400, 300);*/

            //  더블 버퍼링 세트 1
            context = BufferedGraphicsManager.Current;//참조
            context.MaximumBuffer = new Size(800, 600);//버퍼크기 설정
            graphics = context.Allocate(CreateGraphics(), 
                new Rectangle(0, 0, 800, 600));//버퍼 그래픽스 객체 생성 및 참조
            graphics.Graphics.Clear(Color.Yellow);//버퍼 지우기
            myImage = Image.FromFile("photo.jpg");
            SetClientSizeCore(800, 600);

            //  리소스 이미지 세트1
            /*SetClientSizeCore(Properties.Resources.test1.Width, Properties.Resources.test1.Height);*/
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*//  프로젝트 폴더 → bin 폴더 → Debug 폴더 안에 이미지가 있어야 함
            Image myImage = Image.FromFile("photo.jpg");
            e.Graphics.DrawImage(myImage, 0, 0);*/

            /*Bitmap myBitmap = new Bitmap("test1.jpg");
            SetClientSizeCore(myBitmap.Width, myBitmap.Height);
            e.Graphics.DrawImage(myBitmap, 0, 0);*/

            //  비트맵 세트 1
            /*//  메모리에서 그려지는 부분
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.Yellow);
            for(int i = 0; i < 10; i++)
            {
                //  뒤에 코드가 가려져서 안보임...
                bitmapGraphics.DrawString("C# Programming", Font, Brushes.Black, 10, 10);
            }
            bitmapGraphics.DrawRectangle(Pens.Black, 100, 10, 200, 100);
            //  폼에 출력
            e.Graphics.DrawImage(bitmap, 0, 0);*/

            //  더블 버퍼링 세트 1
            //  더블 버퍼에 출력
            Random rand = new Random();
            for(int i = 0; i < 100; i++)
            {
                graphics.Graphics.DrawImage(myImage, rand.Next(0, 700), rand.Next(0, 500));
            }

            //  화면에 출력
            graphics.Render(e.Graphics);

            //  리소스 이미지 세트1
            /*//  test1 이나 photo로 이미지 파일이 없기 때문에 실행 X
            Bitmap bitmap = Properties.Resources.test1;
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap = Properties.Resources.photo;
            e.Graphics.DrawImage(bitmap, 20, 20);*/
        }
    }
}
