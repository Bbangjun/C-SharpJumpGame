using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class Box
    {
        public Box() //생성자
        {
            Console.WriteLine("박스 생성");
        }
        ~Box() //소멸자
        {
            // * 소멸자 작성 규칙
            //- 클래스이름 앞에 "~"기호를 붙여준다.
            //- 접근제한자를 사용하지 않는다.
            //- 반환자료형을 적지 않는다. (void도 아니다)
            //- 매개변수를 넣을 수 없다.
            //- 하나의 클래스에는 1개의 소멸자만 가질 수 있다.

            Console.WriteLine("박스 소멸");
        }
    }

    class Dest
    {
        public Dest()
        {
            Console.WriteLine("생성");
        }
        ~Dest()
        {
            Console.WriteLine("소멸");
        }
    }

    class _046_Destructor
    {
        static void Destroy()
        {
            Box box = new Box();
        }

        static void Main1(string[] args)
        {
            // * 소멸자(파괴자)
            //- 객체가 소멸될때 호출되는 함수
            //- C#은 객체가 더이상 사용되지 않을것이 확실할때 객체를 소멸시킨다.

            //Box box = new Box();
            Destroy();

            // * 실습
            //- 클래스를 만들고 소멸자 만들기
            Dest dest = new Dest();
        }
    }
}
