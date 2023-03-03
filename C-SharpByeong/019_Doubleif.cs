using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _019_Doubleif
    {
        static void Main19(string[] args)
        {
            // * 2중 if문
            //- if문안에 if문이 있는 것을 의미
            //- &&(AND)연산자와 조건이 같다.

            int a = 10;
            int b = 20;

            if(a == 10) //a가 10과 같다면
            {
                if(b == 20) //b가 20과 같다면
                {
                    Console.WriteLine("a는 10, b는 20");
                }
            }

            if(a == 10 && b == 20)
            {
                Console.WriteLine("a는10, b는 20");
            }

            //2중 if문과 &&(AND)연산자와 조건이 같다.

            // * 실습
            //- 숫자 1개를 입력받아 2중 if문을 활용하여
            //- 음수/양수, 홀수/짝수 를 판단하기
            //- "양수/짝수", "양수/홀수", "음수/짝수", "음수/홀수", 0
            //- 다섯 중 하나를 출력

            string A = Console.ReadLine();
            int num;

            bool IsNum = int.TryParse(A, out num);

            if(IsNum)
            {
                if(num > 0)
                {
                    if ((num % 2) == 0)
                    {
                        Console.WriteLine("양수/짝수");
                    }
                    else if ((num % 2) == 1)
                    {
                        Console.WriteLine("양수/홀수");
                    }
                }
                else if(num < 0)
                {
                    if ((num % 2) == 0)
                    {
                        Console.WriteLine("음수/짝수");
                    }
                    else if (Math.Abs(num % 2) == 1)
                    {
                        Console.WriteLine("음수/홀수");
                    }
                }
               
                else if (num == 0)
                {
                    Console.WriteLine("0입니다.");
                }
            }
            else
            {
                Console.WriteLine("숫자만 입력해주세요.");
            }
        }
    }
}
