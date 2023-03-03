using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _040_Constructor
    {
        class Warrior
        {
            public Warrior() //생성자
            {
                Console.WriteLine("전사 생성");
            }
        }

        class Wizard
        {
            public Wizard() //생성자
            {
                Console.WriteLine("마법사 생성");
            }
        }

        class Ninja
        {
            public Ninja()
            {
                Console.WriteLine("닌자 생성");
            }
        }

        static void Main1(string[] args)
        {
            // * 생성자
            //- 객체를 만들때 자동으로 호출되는 함수
            //- 클래스 이름과 같아야 한다.
            //- 반환자료형을 작성하지 않는다.
            //- 접근제한자는 public이어야 한다.
            //- private생성자는 기능이 다르다.

            new Warrior(); //인스턴스 생성
            Wizard wizard = new Wizard();

            // * 객체 : 클래스 타입으로 선언된 변수
            // * 인스턴스 : 메모리에 할당된 클래스의 실체

            // * 실습
            //- Ninja 클래스 만들기
            //- 인스턴스를 만들고 "닌자 생성" 호출 시키기

            new Ninja();
        }
    }
}
