using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _073_Abstract
    {
        abstract class Animal
        {
            public void Eat()
            {
                Console.WriteLine("먹다");
            }

            public abstract void Howling(); //추상메소드
            //- 추상메소드가 있으면 클래스도 추상클래스가 되어야 한다.
        }
        class Dog : Animal
        {
            public override void Howling()
            {
                Console.WriteLine("멍멍");
            }
        }
        class Cat : Animal
        {
            public override void Howling()
            {
                Console.WriteLine("야옹");
            }
        }

        abstract class Unit
        {
            public abstract void Attack();
        }

        class Warrior : Unit
        {
            public override void Attack()
            {
                Console.WriteLine("근접공격");
            }
        }
        class Archer : Unit
        {
            public override void Attack()
            {
                Console.WriteLine("원거리 공격");
            }
        }
        static void Main1(string[] args)
        {
            // * 추상클래스
            //- 객체를 만들 수 없는 클래스
            //- 추상클래스의 목적은 추상메서드를 만드는 역할

            // * 추상메서드
            //- 자식에게 구현을 강제하는 역할
            //- 선언만 가능하며 정의는 자식클래스에서 만들어진다.

            Animal dog = new Dog();
            dog.Howling();

            Animal cat = new Cat();
            cat.Howling();

            // * 실습
            //- Unit 클래스 만들기
            //- Unit의 자식으로 전사, 궁수 클래스 만드릭
            //- Unit에서 자식클래스에게 Attack함수 구현 강제하기

            Warrior warrior = new Warrior();
            warrior.Attack();

            Archer archer = new Archer();
            archer.Attack();
        }
    }
}
