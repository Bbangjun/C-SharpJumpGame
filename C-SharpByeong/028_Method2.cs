using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _028_Method2
    {
        // * 최수값부터 최대값까지 더하는 함수
        static int Sum(int min, int max)
        {
            int result = 0;
            for (int i = min; i < max; i++)
            {
                result += i;

            }
            return result;
        }

        static float Compare(float x, float y)
        {
            float result = (x > y) ? x : y;
            return result;
        }

        static int Value(int x)
        {
            int result;
            if (x < 0)
                result = -x;
            else
                result = x;
            return result;
        }

        static void Main1(string[] args)
        {
            /*
            Console.WriteLine(Sum(1, 10));
            Console.WriteLine(Sum(50, 100));
            Console.WriteLine(Sum(30, 120));

            // * 삼항연산자
            //- (조건식) ? (true인 경우) : (false인 경우)

            int result = (10 > 20) ? 10 : 20;
            int a = 3;
            int b = 7;


            Console.WriteLine("큰 값 : " + ((a > b) ? a : b));
            Console.WriteLine(result);
            */


            // * 실습
            //- float형으로 매개변수 2개를 받아서
            //- 삼항연사자를 이용하여 큰값을 반환하는 함수 만들기

            float a;
            float b;

            Console.WriteLine("실수를 두번 입력해주세요.");
            if(float.TryParse(Console.ReadLine(), out a) && float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(a + " 와 " + b + " 중 큰 수는 : " + Compare(a, b));
            }
            else
            {
                Console.WriteLine("잘못된 입력값");
            }

            //int형 1개를 매개변수로 받아서
            //- 절대값을 반환하는 함수 만들기

            int input;
            Console.WriteLine("정수를 입력해주세요.");
            if(int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine(input + " 의 절대값 : " + Value(input));
            }
            else
            {
                Console.WriteLine("잘못된 입력값");
            }
        }
    }
}
