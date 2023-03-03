using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _057_inherit
    {
        class Unit //초보자
        {
            public int str; //힘
            public int dex; //민첩
            public int intel; //지능
            public int luck; //행운
            public void Attack()
            {
                Console.WriteLine("기본공격!");
            }
        }

        class Warrior : Unit//전사
        {
            public void FinalAttack()
            {
                Console.WriteLine("파이널 어택!");
            }
        }
        static void Main1(string[] args)
        {
            // * 상속성
            //- 부모와 자식관계를 정의하는 작업
            //- 부모의 기능을 자식이 사용할 수 있다.
            //- 반복되는 코드를 줄일 수 있다.
            Warrior warrior = new Warrior();
            warrior.str = 10;
            warrior.dex = 20;
            warrior.intel = 30;
            warrior.luck = 40;
            //자식은 부모의 변수들을 사용할 수 있다.
            warrior.Attack();
            warrior.FinalAttack();

            Unit unit = new Unit();
            unit.Attack(); //초보자 공격!
            // unit.FinalAttack(); //자식에 있는 함수는 사용할 수 없음

        }
    }
}
