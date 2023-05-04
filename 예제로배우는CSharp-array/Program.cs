using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제로배우는CSharp_array
{
    class Program
    {
        /*static void Main(string[] args)
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
        }*/

        static void change(int[] arr)
        {
            int tmp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = tmp;
        }
    }
}
