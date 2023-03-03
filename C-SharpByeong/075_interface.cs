using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _075_interface
    {
        class A { }
        class B { }
        //class C : A, B { } //다중상속 불가능

        class Unit
        {
            protected int currentHp;
            protected float speed;
            public void Move()
            {
                Console.WriteLine("이동");
            }
        }

        interface ISword
        {
            //int damage; // 일반변수 사용 불가
            int damage { get; set; }
            void Attack(); //함수는 선언만 가능 기능X
        }

        interface IShield
        {
            int defence { get; set; }
            void Defence();
        }

        class Warrior : Unit, ISword, IShield
        {
            public int damage { get; set; }
            //인터페이스의 멤버는 public으로 구현해야 한다.
            public int defence { get; set; }
            public void Attack()
            {
                Console.WriteLine("공격!");
            }
            public void Defence()
            {
                Console.WriteLine("방어!");
            }
        }

        class Enemy : ISword
        {
            public int damage { get; set; }
            public void Attack()
            {
                Console.WriteLine("휘두르기");
            }
        }
        static void Main1(string[] args)
        {
            // * 인터페이스
            //- C#은 클래스 다중상속이 불가능
            //- 다중상속을 위해서는 interface를 사용해야 함
            //- 추상클래스보다 더 강한 추상성을 지님
            //- 프로퍼티, 메서드, 인덱서만 사용 가능
            //- 모든 멤버는 추상화만 가능(정의할 수 없다)
            //- 모든 멤버는 public이어야 한다.
            //- 이름 앞에 I를 붙여준다. (암묵적인 규칙)
            //- 객체로 만들 수 없다.

            ISword sword = new Warrior();
            sword.Attack();

            ISword enemy = new Enemy();
            enemy.Attack();
        }
    }
}
