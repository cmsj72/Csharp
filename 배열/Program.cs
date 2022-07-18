using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열
{
    /*class Program
    {
        static void Main(string[] args)
        {
            *//*int[] nArray = { 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
                Console.Write("{0} ", nArray[i]);
            Console.Write('\n');

            for (int i = 0; i < nArray.Length; i++)
                Console.Write("{0} ", nArray[i]);
            Console.Write('\n');

            foreach (int m in nArray)
                Console.Write("{0} ", m);
            Console.Write('\n');
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            foreach (string str in Days)
                Console.Write(str + " ");*//*

            //====

            *//*int[,] nArray1 = new int[2, 2];
            nArray1[0, 0] = 1;
            nArray1[0, 1] = 2;
            nArray1[1, 0] = 3;
            nArray1[1, 1] = 4;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray1[i, j] + " ");
            Console.Write('\n');

            int[,] nArray2 = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray1[i, j] + " ");
            Console.Write('\n');

            string[,,] strArray = { { { "ab", "cd" }, { "ef", "gh" } },
            { { "ij", "kl" }, { "mn", "op" } } };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        Console.Write(strArray[i, j, k] + " ");*//*

            //====

            *//*int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j]);
                //가변배열 표현할때는 array[i][j] 처럼 하는듯하다.
            }*//*

            //====

            int[][][] array3 = new int[2][][];
            array3[0] = new int[2][];   // 2개의 행
            array3[1] = new int[3][];   // 3개의 행

            array3[0][0] = new int[3] { 1, 2, 3 };
            array3[0][1] = new int[2] { 4, 5 };

            array3[1][0] = new int[3] { 6, 7, 8 };
            array3[1][1] = new int[2] { 9, 10 };
            array3[1][2] = new int[2] { 11, 12 };

            for(int i = 0; i < array3.Length; i++)
            {
                for(int j = 0; j < array3[i].Length; j++)
                {
                    for(int k = 0; k < array3[i][j].Length; k++)
                    {
                        Console.Write("{0} ", array3[i][j][k]);
                    }
                }
            }
        }
    }*/

    class Program
    {
        static void TransArray(string[] arr)
        {
            // arr은 Days의 참조형 배열 변수
            string[] HangulDays = { "일", "월", "화", "수", "목", "금", "토" };
            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = HangulDays[i];
            }
        }

        static void Main(string[] args)
        {
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            TransArray(Days);
            foreach (string str in Days)
                Console.Write(str + " ");
        }
    }
}
