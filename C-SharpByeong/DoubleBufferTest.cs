using System;

namespace C_SharpByeong
{

    class DoubleBufferTest
    {
        static int width = 50;
        static int height = 10;
        static char[,] front_buffer = new char[height, width];
        static char [,] back_buffer = new char[height, width];
        static Random rnd = new Random();
        static int rndvalue;

        static public void BufferMove()
        {
            char temp = ' ';
            char temp2 = ' ';
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {
                    if(j == 0)
                    {
                        temp = back_buffer[i, j + 1]; // 1번인덱스가 temp에 저장
                        back_buffer[i, j + 1] = back_buffer[i, j]; // 1번인덱스에 0번인덱스 저장
                        back_buffer[i, j] = ' '; //0번인덱스 초기화
                    }
                    if(j != 0)
                    {
                        temp2 = temp; //temp2에 기존 1번 인덱스 저장 - temp2에 기존 2번 인덱스 저장
                        temp = back_buffer[i, j + 1]; // 2번인덱스를 temp에 저장 - 3번인덱스를 temp에 저장
                        back_buffer[i, j + 1] = temp2; // 2번인덱스에 기존 1번 인덱스 저장 -3번인덱스에 기존 2번 인덱스 저장
                    }
                }
            }

        }
        static public void Buffer()
        {
            Console.SetCursorPosition(0, 0);


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i < 6 && j < 30)
                    {
                        rndvalue = rnd.Next(0, 3);
                        switch (rndvalue)
                        {
                            case 0:
                                back_buffer[i, j] = 'a';
                                break;
                            case 1:
                                back_buffer[i, j] = 'b';
                                break;
                            case 2:
                                back_buffer[i, j] = 'c';
                                break;

                        }
                    }
                    else
                        back_buffer[i, j] = ' ';
                }
            }

            front_buffer = back_buffer;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(front_buffer[i, j]);
                    if (j == width - 1)
                        Console.WriteLine();
                }
            }


        }
        static void Main1(string[] args)
        {
            Buffer();

            while (true)
            {

                BufferMove();

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(front_buffer[i, j]);
                        if (j == width - 1)
                            Console.WriteLine();
                    }
                }

                System.Threading.Thread.Sleep(50);
                
                
            }
        }
    }
}
