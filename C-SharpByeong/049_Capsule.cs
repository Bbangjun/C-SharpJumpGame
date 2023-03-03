using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{

    class _049_Capsule
    {
        class GameManager
        {
            private int money = 100;
            private int crystal = 10;
            public int GetMoney()
            {
                return money;
            }
            public void SetMoney(int money)
            {
                if (money >= 0)
                {
                    this.money = money;
                }
                else
                {
                    Console.WriteLine("Money의 값이 음수입니다.");
                }
            }

            public int GetCrystal()
            {
                return crystal;
            }
            public void SetCrystal(int crystal)
            {
                if(crystal < 0)
                {
                    Console.WriteLine("입력값 오류");
                }
                else if(crystal >= 0 && crystal <= 500)
                {
                    this.crystal = crystal;
                }
            }
        }
        
        
        static void Main1(string[] args)
        {
            // * 캡슐화
            //- 변수와 함수를 하나로 묶는 과정
            //- 변수를 private선언하여 클래스 외부에서 접근할 수 없게 함
            //- public을 통해 정의된 함수(Getter, Setter)를 통해 변수에 접근
            //- 캡슐화를 통하여 값의 유효성 검사를 할 수 있다.

            GameManager GM = new GameManager();
            Console.WriteLine("머니 : " + GM.GetMoney());
            GM.SetMoney(50);
            Console.WriteLine("머니 : " + GM.GetMoney());

            // * 실습
            //- GameManager 클래스에 int crystal 변수 만들기
            //- crystal 변수를 캡슐화(Getter, Setter만들기) 하기
            //- crystal 변수의 값을 읽을때마다 "읽음"출력
            //- crystal 변수는 0~500까지의 값만 가질 수 있음 

            Console.WriteLine(GM.GetCrystal());
            GM.SetCrystal(100);
            Console.WriteLine(GM.GetCrystal());
            GM.SetCrystal(-100);
        }
    }
}
