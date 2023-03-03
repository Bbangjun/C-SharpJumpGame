using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _074_indexer
    {
        class MyList
        {
            public int[] array;
            public MyList()
            {
                array = new int[5];
            }

            public int this[int index]
            {
                get { return array[index]; }
                set { array[index] = value; }
            }
            public int Length
            {
                get { return array.Length; }
                
            }

        }
        static void Main1(string[] args)
        {
            // * 인덱서
            //- 배열의 특징을 가진 프로퍼티
            //- 클래스, 구조체, 인터페이스 멤버에 접근 할 수 있음
            //- 클래스 외부에서는 객체를 배열처럼 사용 가능

            MyList my = new MyList();
            my[0] = 10;
            Console.WriteLine(my[0]);
            Console.WriteLine(my.array[0]);
            Console.WriteLine(my.Length);
            my[1] = 20;
            my[2] = 30;

            for (int i = 0; i < my.Length; i++)
            {
                my[i] = i * 20;
                Console.WriteLine(my[i]);
            }

        }
    }
}
