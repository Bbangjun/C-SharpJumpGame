using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _050_Property1
    {
        class GameManager
        {
            private int money = 100;
            private float crystal = 50.5f;
            private string hello = "Hello, World";
            private double two = 44.4;

            public float Crystal
            {
                get { return crystal; }
                set { crystal = value; }
            }

            public string Hello
            {
                get { return hello; }
                set { hello = value; }
            }

            public double Two
            {
                get { return two; }
                set { two = value; }
            }

            // * 프로퍼티
            public int Money
            {
                get { return money; } //getter
                set { money = value; } //setter
                // value : 프로퍼티에 사용되는 키워드
                //프로퍼티에 들어온 값이 value에 저장된다.
            }
        }
        static void Main1(string[] args)
        {
            // * 프로퍼티
            //- 속성이라는 뜻을 가지고 있음
            //- getter와 setter를 간단히 표현한 것

            GameManager GM = new GameManager();
            Console.WriteLine(GM.Money);
            GM.Money = 500;
            Console.WriteLine(GM.Money);

            // * 실습
            //- GameManage에 float crystal 변수 만들기
            //- crystal의 프로퍼티 만들기
            //- string형변수 만들고 프로퍼티 만들기
            //- double형 변수 만들고 프로퍼티 만들기

            Console.WriteLine("=========================");
            Console.WriteLine(GM.Crystal);
            GM.Crystal = 33.3f;
            Console.WriteLine(GM.Crystal);
            Console.WriteLine(GM.Hello);
            GM.Hello = "HELLO";
            Console.WriteLine(GM.Hello);
            Console.WriteLine(GM.Two);
            GM.Two = 22.2;
            Console.WriteLine(GM.Two);
        }
    }
}
