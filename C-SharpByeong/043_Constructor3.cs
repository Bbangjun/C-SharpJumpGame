using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _043_Constructor3
    {
        class Hidden
        {
            private Hidden()
            {
                Console.WriteLine("인스턴스 생성 불가");
            }
            public Hidden(int num)
            {
                Console.WriteLine("인스턴스 생성 가능");
            }
        }
        static void Main1(string[] args)
        {
            // * private 생성자
            //- 외부에서 인스턴스생성을 못하게 하는 역할

            //Hidden hiddenA = new Hidden();
            //private생성자는 인스턴스를 생성할 수 없다.
            //외부에서 객체생성을 못하게 할 때 사용

            Hidden hiddenB = new Hidden(5);
            //public 생성자는 외부에서 객체생성 가능
        }
    }
}
