using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _022_for
    {
        static void Main22(string[] args)
        {

            // * for문(반복문)
            //- for(초기식; 조건식; 증감식)
            //- 초기식 : 변수선언 및 초기값 지정
            //- 조건식 : 조건이 true면 반복, false면 종료
            //- 증감식 : 반복할때마다 값을 증가 혹은 감소

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("유니티");
            }

            // * 실습
            //- for문으로 Hello 10번 출력하기

            for(int i =0; i < 10; i++)
            {
                Console.WriteLine("Hello "+ (i+1));
            }

            // * 감소식
            for(int i =3; i>0; i--)
            {
                Console.WriteLine("감소식");
            }

            // * 2씩 증가
            for(int i = 0; i<10; i+=2)
            {
                Console.WriteLine("i : " + i);
            }

            // * 무한 반복
            //- for문의 조건식에 조건이 없거나 true면 무한반복
            //- 무한반복시 종료조건을 넣어주거나
            //- 컴퓨터가 쉴 수있는 시간을 넣어야 함

            for(; ; )
            {
                Console.WriteLine("테스트");
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                    break; //반복문 종료
            }
        }
    }
}
