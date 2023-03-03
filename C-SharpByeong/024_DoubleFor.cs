using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _024_DoubleFor
    {
        static void Main1(string[] args)
        {
            // * 2중 for문
            //- for문 안에 for문이 있는 것
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("<{0}, {1}>", i, j);
                }
                Console.WriteLine();
            }//10번 * 10번 = 100번을 반복한다.

            // * 실습
            //- 2중 for문으로 *을 출력
            //- ***
            //- ***
            //- ***

            Console.WriteLine("==========================\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("==========================\n");
            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i == 0 || i == 4)
                    {
                        Console.Write("*");
                    }
                    else if (i >0 && i< 4)
                    {
                        if (j == 0 || j == 4)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            */

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (i == 0 && j == 7)
                    {
                        Console.Write("*");
                    }
                    else if (i ==0 && j != 7)
                    {
                        Console.Write(" ");
                    }
                    if(i == 1 && (j ==6 || j==8))
                    {
                        Console.Write("*");
                    }
                    else if(i== 1 && (j!= 6 || j!=8))
                    {
                        Console.Write(" ");
                    }
                    if(i == 2 && (j == 5 || j==9))
                    {
                        Console.Write("*");
                    }
                    else if(i == 2 && (j != 5 || j != 9))
                    {
                        Console.Write(" ");
                    }
                    if(i == 3 && ((j>=0 && j<5) || (j<15  && j > 9)))
                    {
                        Console.Write("*");
                    }
                    else if(i == 3 && (j >= 5 && j <10 ))
                    {
                        Console.Write(" ");
                    }
                    if(i == 4 && (j == 1 || j == 13))
                    {
                        Console.Write("*");
                    }
                    else if(i == 4 && (j != 1 || j != 13))
                    {
                        Console.Write(" ");
                    }
                    if(i == 5 && (j == 2 || j == 12))
                    {
                        Console.Write("*");
                    }
                    else if(i == 5 && (j != 2 || j != 12))
                    {
                        Console.Write(" ");
                    }
                    if (i == 6 && (j == 2 || j == 12 || j == 7))
                    {
                        Console.Write("*");
                    }
                    else if (i == 6 && (j != 2 || j != 12 || j != 7))
                    {
                        Console.Write(" ");
                    }
                    if (i == 7 && (j == 2 || j == 12 || j == 6 || j == 8))
                    {
                        Console.Write("*");
                    }
                    else if (i == 7 && (j != 2 || j != 12 || j != 6 || j != 8))
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
