using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _059_inherit2
    {
        class Weapon
        {
            public Weapon() { Console.WriteLine("무기 생성"); }
            
            ~Weapon() { Console.WriteLine("무기 소멸"); }
        }
        class Sword : Weapon
        {
            public Sword() { Console.WriteLine("소드 생성"); }
            ~Sword() { Console.WriteLine("소드 소멸"); }
        }

        class Newbie
        {
            protected int str = 5;
            protected int dex = 5;
            protected int intel = 5;
            protected int luck = 5;
            protected int damage;
            public Newbie() { Console.WriteLine("초보자 생성"); damage = str; }
            public void Attack() { Console.WriteLine("기본 공격! 대미지 : " + damage); }
            ~Newbie() { Console.WriteLine("캐릭터 소멸"); }
        }

        class Warrior : Newbie
        {
            
            public Warrior() { Console.WriteLine("전사 생성"); str = 10; }
            ~Warrior() { Console.WriteLine("전사 삭제"); }
        }
        
        class Archer : Newbie
        {
            public Archer() { Console.WriteLine("궁수 생성"); dex = 10; damage = dex; }
            ~Archer() { Console.WriteLine("궁수 삭제"); }
        }

        class Knight : Warrior
        {
            public Knight() { Console.WriteLine("기사 생성"); }
            ~Knight() { Console.WriteLine("기사 삭제"); }
        }
        class Paladin : Warrior
        {
            public Paladin() { Console.WriteLine("성기사 생성"); }
            ~Paladin() { Console.WriteLine("성기사 삭제"); }
        }
        class Hunter : Archer
        {
            public Hunter() { Console.WriteLine("사냥꾼 생성"); }
            ~Hunter() { Console.WriteLine("사냥꾼 삭제"); }
        }
        class Ranger : Archer
        {
            public Ranger() { Console.WriteLine("레인저 생성"); }
            ~Ranger() { Console.WriteLine("레인저 삭제"); }
        }




        static void Main1(string[] args)
        {
            // * 상속과 생성 순서
            //- 부모를 상속받으면 자식은 부모의 변수와 함수를 가진다.
            //- 부모의 변수와 함수를 가질 수 있는 이유는
            //- 컴파일러가 부모를 만들어서 자식에게 넣어주기 때문
            //- 즉, 자식을 만들면 부모도 같이 만든다.

            // * 생성순서 : 부모 -> 자식
            // * 소멸순서 : 자식 -> 부모
            Sword sword = new Sword();

            // * 실습
            //- 초보자 클래스 만들기
            //- 초보자 클래스를 상속받는 전사, 아처 클래스 만들기
            //- 전사를 상속받는 Knight, Paladin클래스 만들기
            //- 아처(Archer)를 상속받는 Hunter, Ranger 클래스 만들기

            Newbie newbie = new Newbie();
            newbie.Attack();

            Warrior warrior = new Warrior();
            warrior.Attack();

            Archer archer = new Archer();
            archer.Attack();

            Knight knight = new Knight();
            knight.Attack();

            Ranger ranger = new Ranger();
            ranger.Attack();
        }
    }
}
