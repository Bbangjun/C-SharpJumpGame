using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _106_SnailMove
    {
        static void Main1(string[] args)
        {
            int x = 1;
            int y = 5;
            while (x < 50) //50보다 작을때까지 반복
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.Write("@__");
                else if (x % 3 == 1)
                    Console.Write("@_^");
                else
                    Console.Write("@_");
                System.Threading.Thread.Sleep(50); // 0.1초 대기

                x++;
            }
            while( x > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.Write("__@");
                else if (x % 3 == 1)
                    Console.Write("^_@");
                else
                    Console.Write("_@");
                System.Threading.Thread.Sleep(50); // 0.1초 대기

                x--;
            }
            while( y < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                
                if(y % 3 == 0)
                {
                    Console.Write("@");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("|");
                }
                else if (y % 3 == 1)
                {
                    Console.Write("@");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("<");
                }
                else
                {
                    Console.Write("@");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("|");
                }

                System.Threading.Thread.Sleep(50); // 0.1초 대기
                y++;
            }
            // * 실습
            //- 오른쪽으로 다 이동하면
            //- 왼쪽으로 이동하도록 구현
        }
    }
}
