using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _070_Partial
    {
        partial class Person
        {
            private string name;
            public string Name
            { 
                get { return name; } 
                set { name = value; } 
            }
        }
        partial class Person
        {
            private int age;
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }
        partial class Person
        {
            public void Print()
            {
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("나이 : " + age);
            }
        }
        static void Main1(string[] args)
        {
            // * 클래스 분할
            //- 1개의 클래스를 여러 파일에 정의 가능
            //- 사람이 봤을때는 분할된것 처럼 보여짐
            //- 컴파일러는 하나의 클래스로 합쳐서 실행
            //- 1개의 클래스를 여러 프로그래머가 작업할때 사용

            Person person = new Person();
            person.Name = "홍길동";
            person.Age = 15;
            person.Print();
        }
    }
}
