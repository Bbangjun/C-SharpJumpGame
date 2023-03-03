using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _064_SataticBinding
    {
        class Unit
        {
            protected float hp = 100;
            public void Hit(float damage) //데미지 받는 함수
            {
                hp -= damage;
                Console.WriteLine("남은 체력 : " + hp);
                if(hp <= 0)
                {
                    Console.WriteLine("죽음");
                }
            }
        }

        class Warrior : Unit
        {
            public void Hit(float damage)
            {
                // * 전사는 50% 데미지 절감 패시브가 있다.
                hp -= damage / 2;
                Console.WriteLine("전사 체력 : " + hp);
            }
        }

        class Monster
        {
            float power = 10; // 몬스터의 공격력
            public void Attack(Unit unit)
            {
                //3개 직업중 어떤 직업이 맞을지 모르기때문에
                //업캐스팅을 이용하여 상대방의 정보를 받아옴

                unit.Hit(power); //데미지 전달
            }
        }

        class Thief : Unit
        {
            public void Hit(float damage)
            {
                // * 도적은 50%확률로 공격을 회피한다
                Random rnd = new Random();
                int random = rnd.Next(0, 2); //0이상 2미만의 난수
                if(random == 0)
                {
                    hp -= damage;
                    Console.WriteLine("회피 실패 : " + hp);
                }
                else
                {
                    Console.WriteLine("회피 성공");
                }
            }
        }
        static void Main1(string[] args)
        {
            // * 정적바인딩
            //- 컴파일시 클래스와 함수가 연결되는 것

            Unit chobo = new Unit();
            Warrior warrior = new Warrior();
            Thief thief = new Thief();

            Monster monster = new Monster();
            monster.Attack(chobo);
            monster.Attack(warrior);
            monster.Attack(thief);
        }
    }
}
