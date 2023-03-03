using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _042_Constructor2
    {
        class Product
        {
            public string name = "제품명";
            public int price = 0;
            public Product()
            {
                name = "무제";
                price = 999;
                Console.WriteLine("제품명 : " + name);
                Console.WriteLine("가격 : " + price);
            }

            public Product(string _name)
            {
                name = _name;
                price = 999;
                Console.WriteLine("제품명 : " + name);
                Console.WriteLine("가격 : " + price);
            }
            public Product(string _name, int _price)
            {
                name = _name;
                price = _price;
                Console.WriteLine("제품명 : " + name);
                Console.WriteLine("가격 : " + price);
            }
        }

        class Monster
        {
            string name;
            int level;
            int damage;
            public Monster(string name, int level, int damage)
            {
                this.name = name;
                this.level = level;
                this.damage = damage;

                Console.WriteLine("이름 : " + this.name);
                Console.WriteLine("레벨 : " + this.level);
                Console.WriteLine("공격력 : " + this.damage);
            }
        }
        static void Main1(string[] args)
        {
            // * 생성자 오버로딩
            //- 생성자도 매개변수를 가질 수 있다.
            //- 매개변수의 자료형 및 갯수가 다르면 다른함수 취급

            Product product = new Product(); //매개변수가 없는 생성자

            Product Gamja = new Product("감자"); //매개변수 1개 생성자

            Product Apple = new Product("사과", 5000); //매개변수 2개 생성자
            
            // * 실습
            //- Monster 클래스 만들고
            //- 변수 3개 만들기
            //= 생성자 오버로딩을 통해 변수의 값을 넣ㅇ르 수 있는 생성자 만들고
            //- Main함수에서 호출

            Console.WriteLine("========================");
            Monster monster = new Monster("쥐", 2, 4);
        }
    }
}
