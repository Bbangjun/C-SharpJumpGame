using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _082_Shorting
    {
        static void Main1(string[] args)
        {
            // * 정렬 알고리즘

            int[] data = { 3, 2, 1, 5, 4 };

            //오름차순 정렬
            for(int i = 0; i<data.Length - 1; i++) //최대갯수 -1 만큼 검사
            {
                for (int j = i + 1; j < data.Length; j++) //최대갯수 만큼 검사 i값의 다음부터
                {
                    if(data[i] > data[j])
                    {
                        //순서를 바꿈
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("/" + data[i]);
            }
            Console.WriteLine(); //개행

            for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = i+1; j < data.Length; j++)
                {
                    if(data[i] < data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("/" + data[i]);
            }
        }
    }
}
