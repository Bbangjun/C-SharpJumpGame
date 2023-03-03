using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _109_StarMove
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("아무키나 누르면 게임 시작");
            Console.ReadKey(); //키 입력 받을때까지 대기

            char ch = '*'; //출력될 문자 변수
            bool gameLive = true; //게임 진행 여부
            ConsoleKeyInfo input; //누른키의 정보를 저장할 변수

            int x = 0, y = 2; //위치 변수
            int dx = 1, dy = 0; //이동할 방향 변수
            int WidthLimit = 80; //화면 범위 제한
            int HeightLimit = 25; //화면 범위 제한

            Console.Clear(); //화면전체를 지워줌

            int delay = 50; //딜레이 변수 (0.05초)

            bool trail = true; //잔상을 남길지 여부

            while(gameLive)
            {
                ConsoleColor cc = Console.ForegroundColor;
                //Console.ForegroundColor : 현재 콘솔에 출력되는 색상
                Console.ForegroundColor = ConsoleColor.White;
                //앞으로 출력되는 글자의 색을 흰색으로 변경
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("이동 : 방향키 / 꼬리 : T / 지우기 : C / 종료 : ESC");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = cc; //다시 원래 색상으로 변경

                //키를 누를 수 있는지 검사
                if(Console.KeyAvailable)
                {
                    input = Console.ReadKey(true);
                    //입력받은 키 정보를 input변수에 저장
                    //true를 넣어주면 입력한 문자를 화면에 출력하지 않음

                    switch(input.Key)
                    {
                        case ConsoleKey.T:
                            trail = !trail;
                            break;
                        case ConsoleKey.C:
                            Console.Clear();
                            break;
                        case ConsoleKey.UpArrow:
                            dx = 0;
                            dy = -1; //이동방향을 위로
                            Console.ForegroundColor = ConsoleColor.Red;
                            //앞으로 출력될 색상을 빨간색으로
                            break;
                        case ConsoleKey.DownArrow:
                            dx = 0;
                            dy = 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case ConsoleKey.LeftArrow:
                            dx = -1;
                            dy = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case ConsoleKey.RightArrow:
                            dx = 1;
                            dy = 0;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case ConsoleKey.Escape: //ESC키
                            gameLive = false; //while문 종료
                            break;

                    }
                }

                Console.SetCursorPosition(x, y);
                if (trail == false)
                    Console.Write(' '); //현재위치를 지움

                x += dx; //x축 방향으로 좌표 이동
                if (x > WidthLimit) //범위를 벗어나면
                    x = 0; //처음위치로
                if (x < 0) //처음위치를 벗어나면
                    x = WidthLimit; //화면 끝으로

                y += dy;
                if (y > HeightLimit)
                    y = 2;
                if (y < 2)
                    y = HeightLimit;

                Console.SetCursorPosition(x, y);
                Console.Write(ch); //별을 그렺무

                System.Threading.Thread.Sleep(delay); //0.5초 대기
            }
        }
    }
}
