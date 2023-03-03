using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _093_DelegateChain
    {
        static void PrintA()
        {
            Console.WriteLine("첫번째");
        }
        static void PrintB()
        {
            Console.WriteLine("두번째");
        }
        static void PrintC()
        {
            Console.WriteLine("세번째");
        }

        delegate void MyDel();
        static void Main1(string[] args)
        {
            // * 델리게이트 체인
            //- 하나의 델리게이트에 여러개의 함수를 등록하여 한꺼번에 호출하는 방법

            MyDel myDel = new MyDel(PrintA);
            myDel += new MyDel(PrintB);
            myDel += new MyDel(PrintC);

            myDel();

            myDel -= new MyDel(PrintB);

            myDel();
        }
    }
}
