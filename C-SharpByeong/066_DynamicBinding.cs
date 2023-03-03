using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _066_DynamicBinding
    {
        class Unit
        {
            float hp = 100;
            float damage = 20;
            public virtual void Hit(float damage)
            {
                hp -= damage;
                Console.WriteLine("남은 체력 : " + hp);
            }

            public virtual void Attack()
            {
                Console.WriteLine("공격");
            }
        }

        class Warrior : Unit
        {
            public override void Hit(float damage)
            {
                base.Hit(damage / 2);
                //부모의 Hit함수를 호출
            }

            public override void Attack()
            {
                Console.WriteLine("근접공격");
            }

        }

        class Thief : Unit
        {
            public override void Hit(float damage)
            {
                Random rnd = new Random();
                int random = rnd.Next(0, 2);

                if (random == 0)
                {
                    Console.WriteLine("회피 실패");
                    base.Hit(damage);
                }
                else
                {
                    Console.WriteLine("회피 성공");
                }
                
            }

            public override void Attack()
            {
                Console.WriteLine("표창공격");
            }
        }

        class Monster
        {
            float power = 10;
            public void Attack(Unit unit)
            {
                unit.Hit(power);
            }
            public void Hit(Unit unit)
            {
                unit.Attack();
            }
        }

        static void Main1(string[] args)
        {
            Unit unit = new Unit();
            Warrior warrior = new Warrior();
            Thief thief = new Thief();

            Monster monster = new Monster();

            monster.Attack(unit);
            monster.Attack(warrior);
            monster.Attack(thief);

            // * 실습
            //- 유닛에 "공격" 출력 함수
            //- 전사에 "근접공격" 출력 함수
            //- 도적에 "표창공격" 출력 함수 만들기

            //- 유닛클래스 변수(객체)에 전사, 도적 인스턴스를 넣었을때
            //- 각각 인스턴스에 맞는 함수 호출시키기

            monster.Hit(unit);
            monster.Hit(warrior);
            monster.Hit(thief);
        }
    }
}
