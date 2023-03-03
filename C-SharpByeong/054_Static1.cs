using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _054_Static1
    {
        class CharacterA
        {
            public int cnt = 0;
            //인스턴스가 만들어질때마다 객체에 개별적으로 할당됨
            public CharacterA()
            {
                cnt++;
                Console.WriteLine("CharacterA : " + cnt);
            }
        }

        class CharacterB
        {
            public static int cnt = 0;//정적 변수
            //클래스의 고정멤버가 됨
            //인스턴스로 객체 개별적으로 변수가 할당되지 않음
            public CharacterB()
            {
                cnt++;
                Console.WriteLine("CharacterA : " + cnt);
            }
    }
        static void Main1(string[] args)
        {
            // * static(정적)
            //- static 키워드를 사용한 변수는 클래스가 메모리 올라갈 때 자동으로 생성
            //- static키워드를 사용해서 선언한 변수는 "정적변수"라 불린다.
            //- 정적변수는 객체와 관계 없이 클래스의 고정멤버가 된다.
            //- 객체를 생성하지 않아도 되므로 편리하다.
            //- 클래스명과 함께 호출해야하며 인스턴스로 사용할 수 없다.
            //- 생성과 함께 프로그램 종료시 소멸

            CharacterA amazon = new CharacterA();
            CharacterA babarian = new CharacterA();
            CharacterA sorceress = new CharacterA();
            babarian.cnt++;

            CharacterB Assasin = new CharacterB();
            CharacterB Druid = new CharacterB();
            CharacterB Paladin = new CharacterB();
            CharacterB.cnt = 10;
            Console.WriteLine("cnt : " + CharacterB.cnt);
            CharacterB Necromancer = new CharacterB();
        }
    }
}
