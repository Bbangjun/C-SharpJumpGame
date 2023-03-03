using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _023_for100
    {
        static void Main23(string[] args)
        {
            // * for문을 이용해서 0~100까지의 합

            int total = 0;
            for(int i = 1; i <= 100; i ++)
            {
                total += i;
            }
            Console.WriteLine("1~100까지의 합 : " + total);

            // * 실습
            //- 100~0(감소식)까지 중 3의 배수의 총 곱을 출력
            
            long mul = 1;
            for(int i = 100; i>0; i--)
            {
                if(i % 3 == 0)
                {
                    mul *= i;
                    Console.WriteLine("곱 : " + mul);
                }
            }
            Console.WriteLine("100~0까지 중 3의 배수의 총 곱 : " + mul);
        }
    }
}
