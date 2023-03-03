using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _104_UpDown
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            int com = rnd.Next(1, 100); //1~99까지의 난수
            int life = 5; //도전기회

            while (true) // 무한반복
            {
                if (life == 0)
                {
                    Console.WriteLine("게임끝 정답 : " + com);
                    Console.WriteLine("재시작 : Y / 종료 : N");
                    string playAgain = Console.ReadLine().ToLower();
                    Console.Clear();
                    //ToLower() : 문자열을 전부 소문자로 바꿔줌
                    if (playAgain == "y")
                    {
                        life = 5;
                        com = rnd.Next(1, 100);
                        continue; //반복을 1번 건너뜀
                    }
                    else if (playAgain == "n")
                    {
                        break; //루프 탈출
                    }
                    else
                    {
                        Console.WriteLine("입력값 에러");
                        break;
                    }

                }
                Console.Write("숫자 입력 : ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input < com)
                    Console.WriteLine("Up");
                else if (input > com)
                    Console.WriteLine("Down");
                else if (input == com)
                {
                    Console.WriteLine("성공! 정답 : " + com);
                    Console.WriteLine("재시작 : Y / 종료 : N");
                    string playAgain = Console.ReadLine().ToLower();
                    Console.Clear();
                    //ToLower() : 문자열을 전부 소문자로 바꿔줌
                    if (playAgain == "y")
                    {
                        life = 5;
                        com = rnd.Next(1, 100);
                        continue; //반복을 1번 건너뜀
                    }
                    else if (playAgain == "n")
                    {
                        break; //루프 탈출
                    }
                }

                life--;
                Console.WriteLine("남은 생명 : " + life);
            }
        }
    }
}
