using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class Test
    {
        static public void Main1(string[] args)
        {
            // * 자료형
            //- 변수에 어떤 데이터 형식을 저장시킬 것인지 아렬주는 역할

            // * 변수
            //- 데이터를 저장하고 전달하는 역할

            int num = 10;
            //int : 정수형 자료형
            //num : 변수
            //= : 오른쪽에 있는 값을 왼쪽 변수에 넣어줌
            //10 : 값

            // * 변수명 작성 규칙
            //- 알파벳, 숫자, 언더바(_)만 사용 가능
            //- 첫 문자를 숫자로 할 수 없음
            //- 변수명이 코드범위 안에서 중복될 수 없다.
            //- 대소문자를 구분한다. (구성이 다르면 별개변수 취급)

            // * 정수형 자료형
            //- short, int, long 2, 4 ,8 byte

            short sh = 123;
            int test = 12;
            long lo = -23;
            Console.WriteLine("short : " + short.MaxValue);
            Console.WriteLine("int : " + int.MaxValue);
            Console.WriteLine("long : " + long.MaxValue);

            // * 실수형 자료형
            //- float, double
            float damage = 12.34f; //4byte
            double speed = 23.45; //8byte

            // * 문자형 자료형
            //- char, string
            char ch = 'f'; //단일 문자만 저장 가능
            string str = "유니티"; //문자열 저장 가능

            // * 사칙연산
            int num1 = 5, num2 = 10;
            Console.WriteLine("num1 + num2 : " + (num1 + num2));
            Console.WriteLine("num1 - num2 : " + (num1 - num2));
            Console.WriteLine("num1 * num2 : " + (num1 * num2));
            Console.WriteLine("num1 / num2 : " + (num1 / num2));
            Console.WriteLine("num1 % num2 : " + (num1 % num2));

            // * 복합대입연산자
            int money = 10;
            money += 5;

            // * 증감연산자
            int nHealth = 5;
            nHealth++; //변수의 값 1증가
            nHealth--; //변수의 값 1감소

            // * 상등연산자
            int aa = 10;
            // == : 갑싱 같다면 true, 다르면 false
            bool isResult = (aa == 10);
            //!= : 값이 다르면 true, 같으면 false
            isResult = (aa != 10); //false

            // * 관계연산자
            // ">" : 좌변이 우변보다 크다면 true, 작거나 같다면  false
            // "<" : 좌변이 우변보다 작다면 true, 크거나 같다면  false
            // ">=" : 좌변이 우변보다  크거나 같으면 true, 작으면 false
            // "<=" : 좌변이 우변보다 작거나 같으면 true, 크다면 false

            // * 논리연산자
            // && (AND) : 그리고
            //- 좌변과 우변 모두 true일때만 true
            //- 1개라도 false라면 false

            // ||(OR) : 또는
            //- Shift + \ : |
            //- 좌변과 우변 중 하나가 true면 true
            //- 두개다 false라면 false

            // !(not) : 부정
            //- true 면 false를 반환
            //- false면 true를 반환

        }
    }
}

// * 주석
//- "//" : 1줄을 컴퓨터가 읽지 않게 해준다.
//- 사용자가 메모를 작성할 수 있게 해줌
//- Ctrl + K + C : 주석처리
//- Ctrl + K + U : 주석해제
