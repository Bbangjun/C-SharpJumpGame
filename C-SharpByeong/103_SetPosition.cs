using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _103_SetPosition
    {
        static void Main1(string[] args)
        {
            int roop = 20;

            Console.WriteLine("출력");
            System.Threading.Thread.Sleep(1000); //1초 대기
            Console.Clear(); //출력문자를 모두 지움
            Console.SetCursorPosition(5, 5); //커서 위치 변경
            Console.Write("위치 변경");
            System.Threading.Thread.Sleep(1000); //1초 대기
            Console.Clear();
            Console.SetCursorPosition(20, 20);
            Console.Write("10, 10의 좌표");
            Console.SetCursorPosition(0, 20);
            Console.Write("0, 10의 좌표");
            Console.SetCursorPosition(20, 0);
            Console.Write("10, 0의 좌표");

            // * 실습
            //- 문자가 이동하는것 처럼 보여지도록 구현

            for(int i = 20; i < 40; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.SetCursorPosition(i, 10);
                Console.Write("ㅇ");
            }

            for (int i = 10; i < 40; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.SetCursorPosition(39, i);
                Console.Write("ㅇ");
            }
            
            while (true)
            {
                
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.SetCursorPosition(5, 20);
                Console.Write("ㅁ");
                Console.SetCursorPosition(5, 21);
                Console.Write("ㅁ");
                Console.SetCursorPosition(0, 22);
                Console.Write("----------------------------------------------------------------------");

                Console.SetCursorPosition(roop, 21);
                Console.Write("ㅣ");
                roop--;
                if(roop == 0)
                {
                    roop = 20;
                }
            }
            
        }
    }
}
