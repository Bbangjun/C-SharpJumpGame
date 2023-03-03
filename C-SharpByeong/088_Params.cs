using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _088_Params
    {
        static void PrintParams(params int[] item)
        {
            int result = 0;
            for (int i = 0; i < item.Length; i++)
            {
                result += item[i];
            }
            Console.WriteLine(result);
        }

        static void FloatParams(params float[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine(item[i]);
            }
        }
        static void Main1(string[] args)
        {
            // * 가변인자(Params)
            //- 인자의 갯수가 일정하지 않은 함수
            //- 인자의 갯수에 제한이 없음
            //- 1차원 배열만 사용이 가능

            PrintParams(10, 20);
            PrintParams(1, 2, 3, 4, 5);
            PrintParams(33, 44, 55, 66, 77, 88, 99);
            Console.WriteLine("==================");

            // * 실습
            //- 가변인자로 flaot형 값을 받아서
            //- 받아온 인자를 모두 출력하는 함수 제작
            //- 호출까지 하기
            FloatParams(1.1f, 2.2f, 3.3f, 4.4f, 5.5f);
        }
    }
}
