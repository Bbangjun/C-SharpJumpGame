using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _021_NoBreak
    {
        enum GameState
        {
            Start = 1,
            Ready,
            Game,
            End
        }
        static void Main1(string[] args)
        {
            /*
            string input = Console.ReadLine();

            // * case사이에 break를 쓰지 않는 경우
            switch(input)
            {
                case "W":
                case "w":
                    //케이스를 연달아서 쓰면 ||(or)의 기능과 같다.
                    Console.WriteLine("위");
                    break;
                case "S":
                case "s":
                    Console.WriteLine("아래");
                    break;
            }
            */
            // * 실습
            //- GameState라는 열거형을 만든다.
            //- 열거형은 Start, Ready, Game, End의 값을 가진다.
            //- switch-case문을 이용하여
            //- 열거형 변수값에 따라 게임의 상태를 출력

            Console.WriteLine("1: Start, 2: Ready, 3: Game, 4: End");

            int ST = Convert.ToInt32(Console.ReadLine());
            GameState state;

            state = (GameState)ST;

            switch(state)
            {
                case GameState.Start:
                    Console.WriteLine("Start");
                    break;
                case GameState.Ready:
                    Console.WriteLine("Ready");
                    break;
                case GameState.Game:
                    Console.WriteLine("Game");
                    break;
                case GameState.End:
                    Console.WriteLine("End");
                    break;
                default:
                    Console.WriteLine("입력값 오류 1~4를 입력해주세요");
                    break;
            }    

        }
    }
}
