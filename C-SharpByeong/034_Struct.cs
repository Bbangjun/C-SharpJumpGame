using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _034_Struct
    {
        struct Person //구조체 정의
        {
            // * 접근지정자
            //- private : 내부에서만 접근 가능
            //- public : 어디서든 접근 가능
            private int Pri;
            public int Pu;
            int non; //접근지정자를 안쓰면 private

            public void Print()
            {
                //구조체 멤버함수에서는 private, public 전부 사용 가능
                Pri = 10;
                Pu = 20;
                non = 30;
                Console.WriteLine(Pri);
            }
        }

        struct Unit
        {
            public string name;
            public int age;
            public float height;

            public void Print()
            {
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("나이 : " + age);
                Console.WriteLine("키 : " + height);
                Console.WriteLine();
            }
        }

        static void Main34(string[] args)
        {
            // * 구조체
            //- 변수와 함수의 모음
            //- 사용자 정의 자료형
            //- value타입
            //- 함수 외부에서 정의해야 함
            Person person = new Person();
            // person.Pri = 10; //private변수는 접근 불가
            person.Pu = 20; // public변수는 접근 가능
            //person.Print();

            Unit Warrior = new Unit();
            Warrior.name = "전사";
            Warrior.age = 12;
            Warrior.height = 234.5f;

            Warrior.Print();

            Unit Archer = new Unit();
            Archer.name = "궁수";
            Archer.age = 22;
            Archer.height = 123.4f;

            Archer.Print();

            // * 실습
            //- Unit구조체를 이용하여 변수명은 Wizard
            //- 이름은 "마법사", 나이는 "33", 키는 "123.4"
            //- 인적정보를 넣고 출력하기

            Unit Wizard = new Unit();
            Wizard.name = "마법사";
            Wizard.age = 33;
            Wizard.height = 123.4f;

            Wizard.Print();
            
        }
    }
}
