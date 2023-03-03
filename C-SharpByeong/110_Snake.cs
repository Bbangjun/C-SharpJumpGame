using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _110_Snake
    {
        class Snake
        {
            int Height = 20;
            int Width = 30;

            int[] x = new int[50];
            int[] y = new int[50];

            int fruitX;
            int fruitY;

            int parts = 3; //기본 꼬리는 3개

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            char key = 's';

            Random rnd = new Random();

            public Snake()
            {
                x[0] = 5; //첫 시작 x좌표
                y[0] = 5; //첫 시작 y좌표
                Console.CursorVisible = false;
                //깜박이는 커서를 안보여줌
                fruitX = rnd.Next(2, Width - 2);
                fruitY = rnd.Next(2, Height - 2);

            }

            //게임판 그리기
            public void WriteBoard()
            {
                Console.Clear();
                for (int i = 1; i <= (Width + 2) ; i++)
                {
                    Console.SetCursorPosition(i, 1);
                    Console.Write("-");
                }
                for (int i = 1; i <= (Width + 2); i++)
                {
                    Console.SetCursorPosition(i, (Height + 2));
                    Console.Write("-");
                }
                //게임판 위아래를 그려줌
                for (int i = 1; i <= (Height + 1) ; i++)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("l");
                }
                for (int i = 1; i <= (Height + 1); i++)
                {
                    Console.SetCursorPosition((Width + 2), i);
                    Console.Write("l"); //소문자 L
                }
                //게임판 좌우를 그려줌
            }

            public void Input()
            {
                //키를 누를 수 있는지 검사
                if(Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    key = keyInfo.KeyChar;
                    //KeyChar : 키를 문자형으로 변환
                }
            }

            public void Logic()
            {
                if(x[0] == fruitX && y[0] == fruitY)
                {
                    parts++;
                    fruitX = rnd.Next(2, (Width - 2));
                    fruitY = rnd.Next(2, (Height - 2));
                }
                for(int i = parts; i > 1; i--)
                {
                    x[i - 1] = x[i - 2];
                    y[i - 1] = y[i - 2];
                }
                switch(key)
                {
                    case 'W':
                    case 'w':
                        y[0]--;
                        break;
                    case 'S':
                    case 's':
                        y[0]++;
                        break;
                    case 'D':
                    case 'd':
                        x[0]++;
                        break;
                    case 'A':
                    case 'a':
                        x[0]--;
                        break;
                }

                for (int i = 0; i <= (parts-1) ; i++)
                {
                    Console.SetCursorPosition(x[i], y[i]);
                    Console.Write("#");

                    Console.SetCursorPosition(fruitX, fruitY);
                    Console.Write("@");
                }
                System.Threading.Thread.Sleep(100);
            }
        }
        static void Main1(string[] args)
        {
            Snake snake = new Snake();
            while(true)
            {
                snake.WriteBoard();
                snake.Input();
                snake.Logic();
            }
            Console.ReadKey();
        }
    }
}
