using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _061_Constructor_init
    {
        class Parent
        {
            public string name;
            public Parent(string _name)
            {
                name = _name;
                Console.WriteLine("부모 : " + name);
            }
            public Parent(string name, int age)
            {
                this.name = name;
                Console.WriteLine("부모 : " + this.name);
                Console.WriteLine("나이 : " + age);
            }
            public Parent(string name, int age, double money)
            {
                this.name = name;
                Console.WriteLine("부모 : " + this.name);
                Console.WriteLine("나이 : " + age);
                Console.WriteLine("돈 : " + money);
            }
        }
        class Child : Parent
        {
            // * 생성자 초기화 리스트
            //- 생성자 괄호 뒤에 콜론(:)으로 표기
            //- 부모클래스의 생성자를 호출하여 부모의 멤버변수 초기화
            public Child() : base("유니티") { }
            //- child가 생성될때 base키워드를 사용하여 부모클래스의 생성자를 호출해 "유니티"문자열 값 전달

            public Child(string _name) : base(_name) { }

            public Child(string name, int age) : base(name, age) { }

            public Child(string name, int age, double money) : base(name, age, money) { }
        }
        static void Main1(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("홍길동");
            // * 실습
            //- Parent클래스에 매개변수 2개인 생성자 만들기
            //- Child클래스에서 초기화리스트로 해당 생성자 호출하여 사용

            //- Parent클래스에 매개변수 3개인 생성자 만들기
            //- Child클래스에서 초기화리스트로 해당 생성자 호출하여 사용

            Child childC = new Child("김철수", 15);
            Child childD = new Child("나명수", 17, 2222.22);
        }
    }
}
