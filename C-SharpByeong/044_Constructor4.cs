using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _044_Constructor4
    {
        class Box
        {
            int num;

            public Box() { }//디폴트 생성자
        }
        
        class Sphere
        {
            public Sphere(int a) { }
        }

        static void Main1(string[] args)
        {
            // * 디폴트 생성자
            //- 매개변수가 없는 생성자
            //- 디폴트생성자가 없다면 컴파일러가 자동으로 디폴트 생성자를 만든다.
            //- 매개변수가 있는 생성자가 있다면 디폴트 생성자를 만들지 않는다.

            Box box = new Box();
            //Sphere sphere = new Sphere();
        }
    }
}
