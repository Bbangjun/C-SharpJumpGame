using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _020_Switch
    {
        static void Main20(string[] args)
        {
            // * switch-case
            //- switch에는 값을 판단할 변수가 들어감
            //- 변수의 값에 따라 알맞는 case를 실행

            int num = 4;
            switch(num)
            {
                case 4:
                    Console.WriteLine("4입니다.");
                    break; // switch-case문 종료
                case 7:
                    Console.WriteLine("7입니다.");
                    break;
                case 9:
                    Console.WriteLine("9입니다.");
                    break;
                default: //  모든 case가 일치하지 않으면 실행
                    Console.WriteLine("4, 7,9가 아닙니다.");
                    break;
            }

            string input = Console.ReadLine();

            switch(input)
            {
                case "a":
                    Console.WriteLine("a입니다.");
                    break;
                case "b":
                    Console.WriteLine("b입니다.");
                    break;
                case "유니티":
                    Console.WriteLine("유니티입니다.");
                    break;
            }
        }
    }
}
