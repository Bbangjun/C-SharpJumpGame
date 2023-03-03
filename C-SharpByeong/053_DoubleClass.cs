using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _053_DoubleClass
    {
        public class OutClass
        {
            public void OutPrint()
            {
                Console.WriteLine("Out!");
            }
            public class InClass
            {
                public void InPrint()
                {
                    Console.WriteLine("In!");
                }
            }
        }

        public class First
        {
            public void FirstPrint()
            {
                Console.WriteLine("First");

            }
            public class Second
            {
                public void SecondPrint()
                {
                    Console.WriteLine("Second");
                }
            }
        }
        static void Main1(string[] args)
        {
            // * 중첩클래스
            //- 클래스 내부에서 클래스를 정의
            //- 클래스 그룹화 가능하며 사용범위 제한 가능
            //- 유저관리 용이
            OutClass Out = new OutClass();
            Out.OutPrint();
            OutClass.InClass In = new OutClass.InClass();
            In.InPrint();

            Console.Clear();
            // * 실습
            //- 중첩클래스 만들어보기
            //- 외부에 있는 클래스에 함수 만들어서 호출
            //- 내부에 있는 클래스에 함수 만들어서 호출
            First first = new First();
            first.FirstPrint();
            First.Second second = new First.Second();
            second.SecondPrint();

        }
    }
}
