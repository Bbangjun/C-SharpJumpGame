using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _030_Overloading
    {
        static void Main30(string[] args)
        {
            // * 오버로딩(오버로드)
            //- 같은 함수 이름으로 함수여러개를 정의하는 방법
            //- 함수의 이름이 같아도 함수의 매개변수의 갯수와 자료형이 다르면 다른함수 취급이 된다

            //DebugLog();
            //DebugLog(3);
            //DebugLog(5.5f);
            //DebugLog(2, 3);

            // * 실습
            //- Print라는 함수 이름으로 오버로딩 하기
            //- 함수 5개 자유롭게 만들기

            int input;
            string StrInput;
            Print();
            Console.Write("숫자를 입력하세요 : ");
            input = Convert.ToInt32(Console.ReadLine());
            Print(input);
            Console.Write("문자를 입력하세요 : ");
            StrInput = Console.ReadLine();
            Print(StrInput);
            Print(3, 5);
            Print("Hello,", "World");
        }


        static void DebugLog()
        {
            Console.WriteLine("DebugLog");
        }
        static void DebugLog(int value)
        {
            Console.WriteLine(value);
        }
        static void DebugLog(float value)
        {
            Console.WriteLine(value);
        }
        static void DebugLog(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }

        static void Print()
        {
            Console.WriteLine("Basic Print");
        }
        static void Print(string str)
        {
            Console.WriteLine("string Print : " + str);
        }
        static void Print(int value)
        {
            int fact = 1;
            for (int i = 0; i < value; i++)
            {
                fact *= i+1; 
            }
            Console.WriteLine("Fact Print : " + fact);
        }
        static void Print(int value1, int value2)
        {
            Console.WriteLine("sum Print : " + (value1 + value2));
        }
        static void Print(string str1, string str2)
        {
            Console.WriteLine("two string Print : " + str1 + " " + str2);
        }
    }
}
