using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _062_ClassCasting
    {
        class Weapon
        {
            public void Attack()
            {
                Console.WriteLine("공격!");
            }
        }

        class Sword : Weapon
        {
            public void SwordAttack()
            {
                Console.WriteLine("소드 어택!");
            }
        }

        class Bow : Weapon
        {
            public void BowAttack()
            {
                Console.WriteLine("보우 어택!");
            }
        }

        class Magic
        {

        }

        class Fire : Magic
        {
            public Fire()
            {
                Console.WriteLine("불공격");
            }
        }
        class Ice : Magic
        {
            public Ice()
            {
                Console.WriteLine("얼음공격");
            }
        }

        class Light : Magic
        {
            public Light()
            {
                Console.WriteLine("빛공격");
            }
        }
        static void Main1(string[] args)
        {
            // * 캐스팅
            //- 변수의 자료형을 변환하는 것

            // * 업캐스팅(UpCasting)
            //- 자식객체의 자료형을 부모로 변환하는 것

            // * 다운캐스팅(DownCasting)
            //- 부모객체의 자료형을 자식으로 변환하는 것
            //- 일반적으로 업캐스팅은 허용되지만 다운캐스팅은 안됨
            Weapon weapon = new Weapon();
            weapon = new Sword(); //업캐스팅
            //자식을 부모에 넣어줄 수 있다.

            //Sword sword = new Weapon();
            //자식에는 부모의 정보가 없으므로 다운캐스팅이 안된다.

            weapon.Attack();
            ((Sword)weapon).SwordAttack(); //다운캐스팅

            weapon = new Bow();
            ((Bow)weapon).BowAttack();

            int num = 10;
            Console.WriteLine((float)num);

            // * 실습
            //- Magic클래스 만들기
            //- 자식으로 Fire, Ice, Light 클래스만들기
            //- Fire -> "불공격" 출력함수
            //- Ice -> "얼음공격" 출력함수
            //- Light -> "빛공격" 출력 함수 만들기
            //- Magic 클래스 객체에 Fire, Ice, Light 인스턴스를 넣엇을때 각 클래스에 맞는 함수 호출시켜주기

            Magic magic = new Magic();
            magic = new Fire();
            magic = new Ice();
            magic = new Light();
        }
    }
}
