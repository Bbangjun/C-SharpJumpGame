using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _051_Property2
    {
        class Game
        {
            private int score = 0; //점수

            public int Score
            {
                get
                {
                    Console.WriteLine("값을 읽음");
                    return score;
                }
                set
                {
                    if(value >= 0)
                    {
                        score = value;
                        Console.WriteLine("score 값 변경" + score);
                    }
                    else
                    {
                        Console.WriteLine("음수가 들어왔다.");
                        score = 0;
                    }
                }
            }
        }

        class Monster
        {
            private float health = 100f;

            public float Health
            {
                get
                {
                    Console.WriteLine("읽음");
                    return health;
                }
                set
                {
                    health = value;
                    if (health <= 0)
                    {
                        Console.WriteLine("죽음");
                        health = 0;
                    }
                    else if(health <= 100)
                    {
                        Console.WriteLine("생존");
                        health = value;
                    }
                    else if(health > 100)
                    {
                        Console.WriteLine("생명력 초과");
                        health = 100;
                    }
                    
                }
            }
        }
        static void Main1(string[] args)
        {
            Game game = new Game();
            game.Score = 100;
            game.Score = -5;
            Console.WriteLine(game.Score);

            Console.WriteLine("=======================");

            // * 실습
            //- Monster클래스 만들기
            //- float health 변수와 프로퍼티 만들기
            //- health값이 0보다 작게 변경되었으면 "죽음"출력
            //- 100 이하라면 "생존" 출력
            //- 100 초과라면 "생명력 초과" 출력
            //- 값을 읽을때마다 "읽음" 출력

            Monster monster = new Monster();
            Console.WriteLine(monster.Health);
            monster.Health = 55;
            Console.WriteLine(monster.Health);
            monster.Health = -1;
            Console.WriteLine(monster.Health);
            monster.Health = 111f;
            Console.WriteLine(monster.Health);

        }
    }
}
