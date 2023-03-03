using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _032_Array2
    {
        static void Main32(string[] args)
        {
            // * 2차원 배열
            int[,] arr = new int[3, 4];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = i + j;
                }
            }

            arr[2, 3] = 10;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("arr[{0}, {1}] : {2}", i, j, arr[i, j]);
                }
            }

            int[] arr2 = { 1, 2, 3, 4 };
            //인덱스공간에 각각 1,2,3,4의 값을 넣어줌
            //공간의 크기는 컴파일러가 자동으로 파악하여 생성
            for(int i = 0; i <arr2.Length; i++)
            {
                Console.WriteLine("arr2 : " + arr2[i]);
            }

            int[,] arr3 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //new int[3, 2]

            for (int i = 0; i <  3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("arr[{0}, {1}] : {2}", i, j, arr3[i, j]);
                }
            }

            // * 실습
            //- float형으로 4,5의 크기를 가지는 2차원 배열 만들기
            //- 모두 더한값을 출력

            float[,] fl = new float[4, 5];
            float sum = 0;

            for (int i = 0; i < fl.GetLength(0); i++)
            {
                for (int j = 0; j < fl.GetLength(1); j++)
                {
                    fl[i, j] = i + j + 1.1f;
                    Console.WriteLine("fl[{0}, {1}] : {2}",i, j,fl[i, j]);
                    sum += fl[i, j];
                }
            }

            Console.WriteLine("총 합 : " + sum);
        }
    }
}
