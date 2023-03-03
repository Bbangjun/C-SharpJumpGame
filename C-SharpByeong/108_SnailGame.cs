using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _108_SnailGame
    {
        static void Main1(string[] args)
        {
            // * 실습
            //- 달팽이 1개 더 추가
            //--------------------------------
            //- 게임시작 전 달팽이 1개 선택
            //- 승자를 맞추면 골드 + 1
            //- 틀리면 골드 - 1

            Random rnd = new Random();
            const string LINE = "----------------------------------------";
            const int END_LINE = 42; // 도착지
            const int DELAY = 200; //0.2초
            int gold = 10;

            

            int[] snail = new int[6]; // 달팽이의 좌표


            Console.Write("승자 예측(1~6) : ");
            int who = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                for (int i = 0; i < snail.Length; i++)
                {
                    ++snail[i]; //모든 달팽이의 좌표를 1씩 증가
                }

                int random = rnd.Next(0, snail.Length);
                ++snail[random]; //랜덤한 달팽이의 좌표 1증가

                System.Threading.Thread.Sleep(DELAY); //0.2초 대기

                Console.Clear(); //화면 전체를 지움

                for (int i = 0; i < snail.Length; i++)
                {
                    Console.WriteLine(LINE);
                    for (int j = 0; j < snail[i]; j++)
                    {
                        Console.Write(" "); //1칸 띄워줌
                    }
                    Console.Write(i + 1); //달팽이 숫자 출력

                    for (int j = (END_LINE - 2) - snail[i]; j >= 0 ; j--)
                    {
                        Console.Write(" ");
                        //달팽이 앞부터 도착지점까지 띄워줌
                    }
                    Console.WriteLine("l"); //도착지점 출력
                    if (i == snail.Length - 1)
                        Console.WriteLine(LINE);
                }

                for(int i = 0; i < snail.Length; i++)
                {
                    if(snail[i] >= END_LINE) //도착지점에 도착햇다면
                    {
                        int winner = i + 1;
                        Console.WriteLine("승자 : " + winner);
                        if(who == winner)
                        {
                            Console.WriteLine("예측 성공! 골드 + 1");
                        }
                        else
                        {
                            Console.WriteLine("예측 실패! 골드 - 1");
                        }
                        Console.WriteLine("재시작 : 0");
                        if(int.Parse(Console.ReadLine()) == 0)
                        {
                            for(int j = 0; j<snail.Length; j++)
                            {
                                snail[j] = 0;
                            }
                        }
                        else
                        {
                            break; //무한반복 종료
                        }


                        Console.Write("승자 예측(1~6) : ");
                        who = Convert.ToInt32(Console.ReadLine());
                    }
                }

            }
        }
    }
}
