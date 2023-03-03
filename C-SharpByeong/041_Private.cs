using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _041_Private
    {
        class MyClass
        {
            int a; // private
            private int b;
            public int c;

            void PrintA() { Console.WriteLine("a : " + a); }
            private void PrintB() { Console.WriteLine("b : " + b); }
            public void PrintC() { Console.WriteLine("c : " + c); }
        }
        static void Main1(string[] args)
        {
            // * 접근제한자(접근지정자)
            //- private : 클래스 내부에서만 접근 가능
            //- public : 어디서든 접근 가능
            //- 접근제한자를 작성하지 않으면 private
            
            MyClass myClass = new MyClass();
            //myClass.a = 10; //private이므로 접근 불가
            //myClass.b = 10;
            myClass.c = 10; //접근 가능

            //myClass.PrintA(); //private이므로 호출 불가
            //myClass.PrintB();
            myClass.PrintC(); //호출 가능
        }
    }
}
