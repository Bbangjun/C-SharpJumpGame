using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _048_Chaning
    {
        class Box
        {
            private float width;
            private float height;

            public Box SetWidth(float _width)
            {
                width = _width;
                return this; // 클래스 자신을 반환
            }
            public Box SetHeight(float _height)
            {
                height = _height;
                return this;
            }
            public Box Print()
            {
                Console.WriteLine("Width : " + width);
                Console.WriteLine("Height : " + height);
                return this;
            }
        }

        class Game
        {
            public Game Start()
            {
                Console.WriteLine("시작");
                return this;
            }
            public Game Ready()
            {
                Console.WriteLine("준비");
                return this;
            }
            public Game Continue()
            {
                Console.WriteLine("진행");
                return this;
            }
            public Game End()
            {
                Console.WriteLine("종료");
                return this;
            }

        }
        static void Main1(string[] args)
        {
            // * 메소드 체이닝 패턴
            //- 함수가 객체를 반환하여 호출을 이어나가는 패턴
            //- 가독성을 향상시킬 수 있다.
            //- 코드 줄 수를 단축시킬 수 있다.

            // * 단점
            //- 에러 발생지점을 찾기 힘들다.
            //- 구조체에 사용하는 경우 구조체 복사가 일어난다.

            Box box = new Box();
            box.SetHeight(10).SetWidth(20).Print();
            box.SetWidth(30).SetHeight(40).Print().Print().Print();

            // * 실습
            //- Game 클래스 만들기
            //- "시작" 출력 함수
            //- "준비"출력 함수
            //- "진행" 출력 함수
            //- "종료" 출력 함수
            //- 메서드 체이닝 패턴을 이용하여 함수들을 순서대로 출력

            Console.WriteLine("=================================");

            Game game = new Game();
            game.Start().Ready().Continue().End();
        }
    }
}
