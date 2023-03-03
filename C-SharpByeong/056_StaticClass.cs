using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _056_StaticClass
    {
        public static class Actor
        {
            static Actor() //정적 생성자
            {
                Console.WriteLine("객체 생성");
            }
            public static int num; //정적 변수

            public static void Print() //정적함수
            {
                Console.WriteLine("num : " + num);
            }
        }
        static void Main1(string[] args)
        {
            // * 정적 클래스
            //- 모든 멤버를 static으로 구성해야 한다.
            //- 생성자에 접근지정자를 사용할 수 없다.
            //- 객체를 생성할 수 없다.
            //- 생성자에 매개변수를 넣을 수 없다.
            Actor.num = 10; //클래스가 생성됨
            Actor.Print();
        }
    }
}
