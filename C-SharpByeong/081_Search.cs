using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _081_Search
    {
        static void Main1(string[] args)
        {
            // * 알고리즘
            //- 알고리즘이란 저장된 데이터를 이용하여 문제를 해결하기 위한
            //- 절차나 방법을 의미

            // * 자료구조
            //- 자료들의 집합
            //- 각 원소들이 논리적으로 정의된 규칙에 의해 나열
            //- 나열된 자료에 대한 처리를 효율적으로 수행할 수 있또록 자료를 구분하여 표현한 것

            // * 선형자료구조
            //- 자료들이 순서대로 나열되ㅡㄴ 구조
            //- 배열, 스택, 큐, 연결리스트, 덱, 해쉬테이블

            // * 비선형자료구조
            //- 복잡한 연결을 갖는 형태
            //- 트리, 그래프

            int[] data = { 1, 3, 5, 7, 9 };
            Console.WriteLine("검색할 값 : ");
            int search = int.Parse(Console.ReadLine());
            bool isFlag = false; //찾았는지 여부
            int index = -1;

            // * 순차검색
            for (int i = 0; i < data.Length; i++)
            {
                if (search == data[i])
                {
                    isFlag = true;
                    index = i; //찾은 위치
                    if (isFlag) break; //반복종료
                }
            }
            if(isFlag) //찾았다면
            {
                Console.WriteLine("찾은 값 : " + search);
                Console.WriteLine("찾은 위치 : " + index);
            }
            else
            {
                Console.WriteLine("찾지 못했습니다.");
            }

            // * 실습
            //- 정수형 값을 입력받고 역순으로 검색하는 알고리즘 작성

            isFlag = false;
            index = -1;


            for(int i=data.Length-1; i>=0; i--)
            {
                if(search == data[i])
                {
                    isFlag = true;
                    index = i;
                    if (isFlag) break;
                }
            }
            if(isFlag)
            {
                Console.WriteLine("찾은 값 : " + search);
                Console.WriteLine("찾은 위치 : " + index);
            }
            else
            {
                Console.WriteLine("찾지 못했습니다.");
            }
        }
    }
}
