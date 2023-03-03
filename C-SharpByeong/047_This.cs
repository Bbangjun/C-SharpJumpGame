using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _047_This
    {
        class Cube
        {
            public string name; //멤버변수 name
            public Cube(string name) //매개변수 name
            {
                // * this
                //- 나 자신이라는 뜻
                //- this가 속한 클래스를 가리킴

                this.name = name;
                Console.WriteLine("이름 : " + this.name);
            }
        }
        static void Main1(string[] args)
        {
            Cube cube = new Cube("큐브");
        }
    }
}
