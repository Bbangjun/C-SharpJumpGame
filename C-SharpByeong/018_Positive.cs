using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _018_Positive
    {
        static void Main18(string[] args)
        {
            // * 숫자 입력받아 음수, 양수 판단하기
            //음수 : 0보다 작은 수
            //양수 : 0보다 큰 수
            //0은 그냥 0

            Console.WriteLine("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());
            if(input == 0)
            {
                Console.WriteLine("0입니다.");
            }
            else if(input > 0)
            {
                Console.WriteLine("양수입니다.");
            }
            else if(input < 0)
            {
                Console.WriteLine("음수입니다.");
            }
        }
    }
}
