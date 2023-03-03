using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _031_Array
    {
        static void Main31(string[] args)
        {
            // * 배열
            //- 동일한 데이터 타입으로 구성된 데이터의 집합
            //- 관련정보를 저장하는 변수 여러개를 하나의 이름으로 모아둔 것
            //- 배열을 구성하는 개별 변수를 "요소"라고 함
            //- 각 배열의 공간 번호를 index(인덱스)라고 함
            //- 배열의 인덱스 번호는 0번부터 시작

            //int score1, score2, score3, score4, score5;
            /* 
            int[] score = new int[5];
            score[0] = 10;
            score[1] = 20;
            score[2] = 30;
            score[3] = 40;
            score[4] = 50;
            //score[5] = 60; // 배열 범위를 벗어남(오류)


            //Console.WriteLine("score[2] : " + score[2]);

            //배열변수명.Length : 배열요소의 갯수
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("score [{0}] : {1}", i, score[i]);
            }
            */
            // * 실습
            //- float형 배열만들기(크기는 4)
            //- 값을 자유롭게 넣고 모두 더한 값 출력

            //- string형 배열 만들기(크기는 7)
            //- 값을 자유롭게 넣고 값을 모두 출력

            float[] fl = new float[4];
            fl[0] = 1.2f;
            fl[1] = 2.3f;
            fl[2] = 3.4f;
            fl[3] = 4.6f;

            float sum = 0;

            string[] str = new string[7];
            str[0] = "반";
            str[1] = "갑";
            str[2] = "습";
            str[3] = "니";
            str[4] = "다";
            str[5] = "람";
            str[6] = "쥐";

            for (int i = 0; i < fl.Length; i++)
            {
                sum += fl[i];
            }
            Console.WriteLine("총 합 : " + sum);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
