using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _026_Continue
    {
  
        static void Main1(string[] args)
        {
            // * continue
            //- 반복을 1회 건너 뜀

            /*
            for (int i = 0; i < 10; i++)
            {
                if (i == 2 || i == 5)
                    continue;
                Console.WriteLine("i : " + i);
            }
            */


            // * 실습
            //- 정수를 입력받고 입력받은 숫자만큼 반복 구현
            //- 반복 횟수 출력
            //- continue를 사용하지 않고 2번째 반복은 출력하지 않음


            int input;

            bool IsNum = int.TryParse(Console.ReadLine(), out input);

            if (IsNum)
            {
                for (int i = 0; i < input; i++)
                {
                    if (i != 1)
                        Console.WriteLine("반복횟수 : " + (i + 1));
                }
            }
            else
            {
                Console.WriteLine("정수만 입력하세요.");
                
                
            }
        }

        


    }
}
