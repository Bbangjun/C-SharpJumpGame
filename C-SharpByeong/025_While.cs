using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _025_While
    {
        static void Main1(string[] args)
        {
            // * while(반복문)
            //- 조건식만 있으며 초기식, 증감식이 없다.
            //- 조건식이 true라면 반복 false면 반복 종료

            int i = 0; // 초기식
            while(i <10) //조건식
            {
                Console.WriteLine("Hello");
                i++; //증감식
            }

            while(true) // 무한 반복
            {
                string input = Console.ReadLine();
                if (input == "a")
                    break; // 반복 종료
            }


        }
    }
}
