using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _107_InputMove
    {

        static int x = 10, y = 10; //시작 좌표

        static int InputKey(ConsoleKey key)
        {
            Console.Clear(); // 화면을 전부 지움
            switch (key)
            {
                case ConsoleKey.UpArrow: // 위 화살표 방향키
                    return -1;
                case ConsoleKey.DownArrow:
                    return 1;
                case ConsoleKey.LeftArrow:
                    return -1;
                case ConsoleKey.RightArrow:
                    return 1;
            }
            return 0;

        }

        static public void CheckPos()
        {
            if (y < 0)
                y = 0;
            else if (x < 0)
                x = 0;
            else if (y > 19)
                y = 19;
            else if (x > 49)
                x = 49;
        }
        static void Main1(string[] args)
        {
            Console.SetCursorPosition(x, y); //커서 이동
            Console.Write("@");
            Console.SetWindowSize(50, 20);
            while(true) // 무한반복
            {
                //Console.ReadLine() : 문자를 입력받아서 반환
                //Console.ReadKey() : 키를 입력받고 키의 정보를 반환
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow || input.Key == ConsoleKey.DownArrow)
                    y += InputKey(input.Key);
                else if (input.Key == ConsoleKey.LeftArrow || input.Key == ConsoleKey.RightArrow)
                    x += InputKey(input.Key);

                CheckPos();
                Console.SetCursorPosition(x, y);
                Console.Write("@");
            }

        }
    }
}
