using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class Product // 제품
    {
        public string name; //제품의 이름
        public int price; //제품의 가격
    }
    class _036_instance
    {
        static void Main1(string[] args)
        {
            // * new
            //- 동적할당
            //- 런타임시 메모리를 할당
            //- 인스턴스를 생성하는데 사용하는 연산자

            // * 인스턴스(instance)
            //- 실제 클래스를 사용할 수 있는 객체
            //- 메모리에 할당된 실체를 의미
            //- 클래스의 복제품

            Product gamja = new Product();
            gamja.name = "감자";
            gamja.price = 1000;
            //객체의 정보를 변경

            Console.WriteLine("이름 : " + gamja.name);
            Console.WriteLine("가격 : " + gamja.price);

            Product grape = new Product();
            grape.name = "포도";
            grape.price = 2000;

            Console.WriteLine("이름 : " + grape.name);
            Console.WriteLine("가격 : " + grape.price);

            // * 실습
            //- Product 클래스를 이용하여
            //- 사과(Apple), 망고(Mango)객체 만들고
            //- 값 넣고 출력

            Product Apple = new Product();
            Apple.name = "사과";
            Apple.price = 3000;

            Console.WriteLine("이름 : " + Apple.name);
            Console.WriteLine("가격 : " + Apple.price);

            Product Mango = new Product();
            Mango.name = "망고";
            Mango.price = 4000;

            Console.WriteLine("이름 : " + Mango.name);
            Console.WriteLine("가격 : " + Mango.price);

        }
    }
}
