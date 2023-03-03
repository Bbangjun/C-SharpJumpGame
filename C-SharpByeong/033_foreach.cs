using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _033_foreach
    {
        static void Main33(string[] args)
        {
            // * foreach
            //- 배열에서만 사용가능한 반복문
            //- 배열의 크기만큼 반복
            //- 반복할때마다 인덱스 순서대로 값이 변수에 들어감
            //- foreach(자료형 변수 in 배열변수)

            int[] arr = { 11, 22, 33, 44, 55 };
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

            float[,] arr2 = { { 1.1f, 2.2f }, { 3.3f, 4.4f }, { 5.5f, 6.6f } };

            foreach(float item in arr2)
            {
                Console.WriteLine("2차원 : " + item);
            }
        }
    }
}
