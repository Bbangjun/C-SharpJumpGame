using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    //int num = 10; //C#은 클래스 외부에 변수를 만들 수 없다.

    class _038_Variable
    {
        // * 전역(필드)
        static public int global = 10; //전역변수, 멤버변수
        //- 객체가 존재하는 한 계속 존속한다.
        static void Print()
        {
            // * 지역(로컬)
            int local = 15; //지역변수
            //- 함수 종료시 소멸됨
            local += 5;
            Console.WriteLine("지역변수 : " + local);
            //함수가 끝나면 local변수는 소멸된다.
        }
        static void Main1(string[] args)
        {
            Print(); //함수를 호출하면 지역변수가 생성된다.
            Print();
            Print();

            global = 20; //전역변수는 사용가능
        }
    }
}
