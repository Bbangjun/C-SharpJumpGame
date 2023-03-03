using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _105_Gawi
    {
        static string SwitchStr(int com) // 컴퓨터 입력값을 문자열로 반환해주는 함수
        {
            switch(com)
            {
                case 1:
                    return "가위";
                case 2:
                    return "바위";
                case 3:
                    return "보";
            }
            return "에러";
        }
        static void GameStart()
        {
            Random rnd = new Random();
            int com = rnd.Next(1, 4); // 1~3까지의 난수
            string userStr; //처음 입력받은 숫자
            int user; //입력받는 값
            int result; // 결과 값
            string comToStr;


            while (true)
            {
                Console.WriteLine("1 : 가위 / 2 : 바위 / 3 : 보");
                Console.Write("입력 : ");
                userStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userStr))
                {
                    Console.WriteLine("입력값이 없습니다.");
                    continue;
                }
                user = Convert.ToInt32(userStr);
                if (user > 0 && user < 4)
                    break;
                else
                {
                    Console.Clear();
                    Console.WriteLine("입력값 에러");
                }
            }
            result = user - com;
            userStr = SwitchStr(user);
            comToStr = SwitchStr(com); // 입력값을 문자열로 반환해주는 함수
            Console.WriteLine("컴퓨터의 입력 : " + comToStr);
            Console.WriteLine("유저의 입력 : " + userStr);
            if (result == 1 || result == -2)
            {
                Console.WriteLine("이김");
                Restart();
            }
            else if (result == 0)
            {
                Console.WriteLine("비김");
                Console.WriteLine("한번 더");
                GameStart();
            }
            else
            {
                Console.WriteLine("짐");
                Restart();
            }
            
        }
        static void Restart()
        {
            string reTry = "";
            Console.Write("재도전 하시겠습니까? Y/N : ");
            reTry = Console.ReadLine().ToLower();
            Console.Clear();
            switch (reTry)
            {
                case "y":
                    Console.WriteLine("재도전");
                    GameStart();
                    break;
                case "n":
                    Console.WriteLine("게임 종료");
                    break;
                default:
                    Console.WriteLine("입력값 에러 다시 입력해주세요");
                    Restart();
                    break;
            }
        }
        static void Main1(string[] args)
        {
            // * 가위바위보 만들기
            //- int com에는 1~3까지 난수가 들어감
            //- int user에는 1~3까지 숫자를 입력받음
            //- com과 user를 뺀다.
            //- 그 값이 같으면 "비김"
            //- 1 또는 -2가 나오면 "이김"
            //- 아니라면 "짐"
            //- 가위 : 1 / 바위 : 2 / 보 : 3

            GameStart();
        }
    }
}
