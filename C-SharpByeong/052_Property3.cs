using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _052_Property3
    {
        class MyClass
        {
            public string Name { get; set; } //자동구현 프로퍼티

            public int Age { get; } = 15;
            //읽기만 가능한 프로퍼티, 초기값은 15

            // * 자동구현 프로퍼티 주의사항
            public int Cnt
            {
                get { return Cnt; } //무한루프
                set { Cnt = value; } //무한루프
            }

            public int Money
            {
                get;
                private set;
            } = 10; //초기값은 10
        }
        static void Main1(string[] args)
        {
            // * 자동구현 프로퍼티
            //- 정보은닉을 좀 더 간결하게 구현 가능

            MyClass myClass = new MyClass();
            myClass.Name = "홍길동";
            Console.WriteLine("이름 : " + myClass.Name);
            Console.WriteLine("나이 : " + myClass.Age);
        }
    }
}
