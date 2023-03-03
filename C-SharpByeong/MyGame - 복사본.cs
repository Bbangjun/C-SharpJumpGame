using System;

namespace C_SharpByeong
{
    class MyGameT
    {
        class JumpMan
        {
            public int x;
            public int y;

            public int score = 0;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

            Random rnd = new Random();

            public int rndWall;
            public int rndWall2;
            public int WallX;
            int WallY;
            int WallY2;

            public int Wall2X;
            public int Wall2Y;
            public int Wall2Y2;

            int high = 0;
            public int level = 1;
            static public int width = 100;
            static public int height = 30;
            static string strScore;
            static char ground = '■';

            char[,] front_buffer = new char[height, width];
            char[,] back_buffer = new char[height, width];


            public bool End = false;

            int count = 0;
            public int delay = 6;

            public JumpMan()
            {
                x = 5;
                y = 29;

                rndWall = rnd.Next(0, 3);
                Console.CursorVisible = false;

                strScore = "점수 : " + score;

                Console.SetWindowSize(width, height);
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            public void Draw()
            {

                strScore = "점수 : " + score;

                front_buffer = new char[height, width];

                front_buffer = back_buffer;

                back_buffer = new char[height, width];


                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0 && j >= 0 && j + 1 < strScore.Length)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(front_buffer[i, j]);
                        }
                        else if (i == height - 1 && j < 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(front_buffer[i, j]);
                        }
                        else if (i == y - 1 && j == x - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(front_buffer[i, j]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(front_buffer[i, j]);
                        }
                        if (j == width - 1)
                            Console.WriteLine();
                    }
                }
                Console.SetCursorPosition(0, 0);
            }

            public void WriteBoard()
            {

                front_buffer = new char[height, width];

                DrawWall(rndWall);


                DrawWall2(rndWall2);

                Draw();

                for (int i = 0; i < height; i++)    // i = height 1 ~ 10 j = width 1 ~ 30
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0 && j >= 0 && j < strScore.Length)
                        {
                            back_buffer[i, j] = strScore[j];
                        }
                        else if(i == height - 1 && j< 50)
                        {
                            back_buffer[i, j] = ground;
                        }
                        else if (i == y - 1 && j == x -1)
                        {
                            back_buffer[i, j] = 'A';
                        }
                        else
                            back_buffer[i, j] = ' ';
                    }
                }

                Console.SetCursorPosition(0, 0);



            }

            public void Input()
            {
                //키를 누를 수 있는지 검사
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Spacebar && count == 0 && high == 0)
                    {
                        count = 3;
                    }
                }

            }

            public void RestartInput()
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    End = false;
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {
                    End = true;
                }
                else
                    RestartInput();
            }

            public void DrawWall(int rndWall)
            {
                if (WallX > 1)
                {
                    switch (rndWall)
                    {
                        case 0:
                            back_buffer[WallY - 1, WallX - 1] = 'l';
                            back_buffer[WallY - 1, WallX - 2] = 'l';
                            break;
                        case 1:
                            back_buffer[WallY - 1, WallX - 1] = 'l';
                            back_buffer[WallY2 - 1, WallX - 1] = 'l';

                            back_buffer[WallY - 1, WallX - 2] = 'l';
                            back_buffer[WallY2 - 1, WallX - 2] = 'l';
                            break;
                        case 2:
                            back_buffer[WallY - 1, WallX - 1] = 'l';
                            back_buffer[WallY2 - 1, WallX - 1] = 'l';

                            back_buffer[WallY - 1, WallX - 2] = 'l';
                            back_buffer[WallY2 - 1, WallX - 2] = 'l';
                            break;
                    }
                }
            }

            public void DrawWall2(int rndWall2)
            {
                if (Wall2X > 1)
                {
                    switch (rndWall2)
                    {
                        case 0:
                            back_buffer[Wall2Y - 1, Wall2X - 1] = 'l';
                            back_buffer[Wall2Y - 1, Wall2X - 2] = 'l';
                            break;
                        case 1:
                            back_buffer[Wall2Y - 1, Wall2X - 1] = 'l';
                            back_buffer[Wall2Y2 - 1, Wall2X - 1] = 'l';

                            back_buffer[Wall2Y - 1, Wall2X - 2] = 'l';
                            back_buffer[Wall2Y2 - 1, Wall2X - 2] = 'l';

                            break;
                        case 2:
                            back_buffer[Wall2Y - 1, Wall2X - 1] = 'l';
                            back_buffer[Wall2Y2 - 1, Wall2X - 1] = 'l';

                            back_buffer[Wall2Y - 1, Wall2X - 2] = 'l';
                            back_buffer[Wall2Y2 - 1, Wall2X - 2] = 'l';
                            break;
                    }
                }
            }

            public void CreateWall()
            {
                if (WallX == level)
                {
                    rndWall = rnd.Next(0, 3);
                }
                switch (rndWall)
                {
                    case 0:
                        WallX = width - 1;
                        WallY = height - 1;
                        WallY2 = height - 1;
                        break;
                    case 1:
                        WallX = width - 1;
                        WallY = height - 4;
                        WallY2 = height - 3;
                        break;
                    case 2:
                        WallX = width - 1;
                        WallY = height - 1;
                        WallY2 = height - 2;
                        break;
                }
            }

            public void CreateWall2()
            {
                if (Wall2X == level)
                {
                    rndWall2 = rnd.Next(0, 3);
                }
                switch (rndWall2)
                {
                    case 0:
                        Wall2X = width - 1;
                        Wall2Y = height - 1;
                        Wall2Y2 = height - 1;
                        break;
                    case 1:
                        Wall2X = width - 1;
                        Wall2Y = height - 4;
                        Wall2Y2 = height - 3;
                        break;
                    case 2:
                        Wall2X = width - 1;
                        Wall2Y = height - 1;
                        Wall2Y2 = height - 2;
                        break;
                }
            }

            public bool Collision()
            {
                if(((WallX == x + 1 || WallX == x) && (WallY == y || WallY2 == y)) || ((Wall2X == x + 1 || Wall2X == x) && (Wall2Y == y || Wall2Y2 == y)))
                {
                    Console.SetCursorPosition(0, 0);
                    WriteBoard();
                    Console.SetCursorPosition(5, 5);
                    Console.Write("게임 오버!");
                    return true;
                }
                return false;
            }

            public void ReStart()
            {
                Console.SetCursorPosition(1, 1);
                Console.Write("재도전? Y/N");
                Console.SetCursorPosition(1, 2);
                Console.Write("최종 점수 : " + score);
                RestartInput();
            }


            public void Logic()
            {


                do
                {


                    if (WallX == 50)
                        CreateWall2();

                    Console.SetCursorPosition(0, 0);
                    Input();

                    if (count > 0)
                    {
                       
                        if (Collision())
                        {
                            End = true;
                            break;
                        }
                        y--;
                        count--;
                        high++;
                        if (Collision())
                        {
                            End = true;
                            break;
                        }
                    }
                    else if (high > 0 && y == height - 4)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (Collision())
                            {
                                End = true;
                                break;
                            }
                            WriteBoard();

                            Wall2X--;
                            WallX--;
                            score++;
                            System.Threading.Thread.Sleep(delay);

                            if (Collision())
                            {
                                End = true;
                                break;
                            }

                            if (i == 2)
                            {
                                y++;
                            }
                        }
                    }
                    else if (high > 0)
                    {
                        y++;
                        high--;
                        if (y > height -1)
                            y = height-1;
                    }

                    if (Collision())
                    {
                        End = true;
                        break;
                    }

                    WriteBoard();

                    if (Wall2X != 0)
                        Wall2X--;
                    WallX--;
                    System.Threading.Thread.Sleep(delay);
                    score++;
                    /*
                    if (score % 100 == 0)
                    {
                        delay -= 10;
                        if (delay < 30)
                            delay = 30;
                    }
                    if (score % 200 == 0)
                    {
                        x++;
                        level++;
                    }*/
                } while (WallX > level);



            }

        }
        static void Main1(string[] args)
        {
            JumpMan man = new JumpMan();
            Random rnd = new Random();
            man.rndWall = rnd.Next(0, 3);

            while (true)
            {
                man.CreateWall();
                man.Logic();

                if(man.End == true)
                {
                    man.ReStart();
                    if (man.End == false)
                    {
                        man.score = 0;
                        man.y = 29;
                        man.x = 5;
                        man.level = 1;
                        man.delay = 30;
                        man.Wall2X = 0;
                        man.Wall2Y = 0;
                        man.Wall2Y2 = 0;
                        continue;
                    }
                    Environment.Exit(0);
                }
            }
                
        }
    }
}
