using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Collections;
namespace C_SharpByeong
{
    class Miro
    {
        static int width = 10;
        static int height = 10;
        static int[] End = new int[2];
        static int[,] start = new int[height, width];
        static int[,] randomvalue = new int[width, height];
        static string[,] miro = new string[width,height];
        static List<Player> list = new List<Player>();
        public class Player
        {
            public int PosX = 1;
            public int PosY = 1;
        }
        public static Player player = new Player();
        public static void Create()
        {
            
            
            Random random = new Random();
            
            int where;
            End[0] = random.Next(3, height);
            End[1] = random.Next(3, width);
            //random[i, j] == 현위치(막혀있을수 없음)
            //random[i, j+1] == 가로 한칸
            //random[i+1, j] == 세로 한칸

            //randomvalue(0, 1) 맵 생성코드
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    randomvalue[i,j] = random.Next(0, 2);
                }
            }
            randomvalue[0, 0] = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    where = random.Next(0, 2);
                    //완전히 막혀있다면 세로, 가로 중 하나를 뚫어줌

                    if((randomvalue[i,j] == 0 && randomvalue[i,j+1] == 1 && randomvalue[i+1, j] == 1) )
                    {
                        if (where == 0)
                            randomvalue[i, j + 1] = 0;
                        else if (where == 1)
                            randomvalue[i + 1, j] = 0;
                    }
                    randomvalue[i, 0] = 1;
                    randomvalue[0, j] = 1;
                    randomvalue[height-1, j] = 1;
                    randomvalue[i, width-1] = 1;
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 1 && j == 1)
                        Console.Write(miro[1,1] = "★");
                    else if (i == End[0] && j == End[1])
                        Console.Write(miro[i,j] = "※");
                    else if (randomvalue[i, j] == 0)
                        Console.Write(miro[i,j] = "□");
                    else if (randomvalue[i, j] == 1)
                        Console.Write(miro[i,j] = "■");
                    if (j == width - 1)
                        Console.WriteLine(); 
                }
            }
        }

        public static void ReDraw()
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(miro[i, j]);
                    if (j == width - 1)
                        Console.WriteLine();
                }
            }
        }

        public static void RightSearch(int i, int j)
        {
            miro[i, j] = "□";
            miro[i, j + 1] = "★";
        }
        public static void UpSearch(int i, int j)
        {
            miro[i, j] = "□";
            miro[i - 1, j] = "★";
        }
        public static void LeftSearch(int i, int j)
        {
            miro[i, j] = "□";
            miro[i, j - 1] = "★";
        }
        public static void DownSearch(int i, int j)
        {
            miro[i, j] = "□";
            miro[i + 1, j] = "★";
        }
 
        public static void Search()
        {
            int i = 0;
            list.Add(player);
            while(true)
            {
                
            }
        }
        static void Main1(string[] args)
        {
            Create();
            Search();
        }
    }
}
/*
 * End[0], End[1] = 5, 10
 * randomvalue[y, x] = 5, 10
 * randomvalue[1, 1] <- 시작 지점
 * 단순계산 으로 y += 4 , x+=9라면 도착
 * but 길이 막혀잇을 수 있음
 * List를 활용해 최단거리 구하기
 */