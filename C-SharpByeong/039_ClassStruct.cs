using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _039_ClassStruct
    {
        struct Mage
        {
            public int hp;
            public int mp;
            public void Print()
            {
                Console.WriteLine("Mage Hp : " + hp);
                Console.WriteLine("Mage Mp : " + mp);
            }
        }

        class Wizard
        {
            public int hp;
            public int mp;
            public void Print()
            {
                Console.WriteLine("Wizard hp : " + hp);
                Console.WriteLine("Wizard mp : " + mp);
            }
        }

        static void Main1(string[] args)
        {
            // * 구조체
            //- 변수와 함수의 모음
            //- 캡슈로하만 가능
            //- value 타입 (복사방식으로 동작)

            // * 클래스
            //- 변수와 함수의 모음
            //- 캡슐화, 상속성, 다형성, 추상성이 있다.
            //- Reference 타입 (참조방식으로 동작)

            Mage mageA;
            Mage mageB;

            mageA.hp = 10;
            mageA.mp = 20;

            mageB = mageA;
            //mageA의 값이 복사되서 mageB에 들어감

            mageB.Print();
            mageA.hp = 99; //mageA의 값을 변경
            mageB.Print(); //mageB의 값은 변하지 않는다.
            mageA.Print();

            Console.WriteLine("---------------------------------");

            Wizard wizardA = new Wizard();
            wizardA.hp = 22;
            wizardA.mp = 33;
            Wizard wizardB = wizardA;

            wizardB.Print();
            wizardA.hp = 88; //위자드 A의 값을 변경
            wizardB.Print();
            wizardA.Print();

            Console.WriteLine("---------------------------------");
            // * string
            //- class이다.
            //- class이므로 reference타입이다.

            string nameA = "홍길동";
            string nameB = nameA;

            Console.WriteLine(nameB);
            nameA = "홍길";
            Console.WriteLine(nameB);
        }
    }
}
