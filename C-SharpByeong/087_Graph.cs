using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _087_Graph
    {
        class Graph
        {
            private int size; //정점의 갯수
            string[] vertices = new string[256]; //정점의 이름
            int[,] adjMat = new int[256, 256]; //엣지(간선)

            public Graph()
            {
                size = 0;
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256; j++)
                    {
                        adjMat[i, j] = 0;
                    }
                }
            }
            bool isEmpty() { return size == 0; }
            bool isFull() { return size >= 256; }

            // * 정점을 가져옴
            public string GetVertex(int i)
            {
                return vertices[i]; //정점 반환
            }
            public int GetEdge(int i, int j)
            {
                return adjMat[i, j]; //간선 반환
            }

            // * 정점 삽입
            public void InsertVertex(string name)
            {
                if(isFull())
                {
                    Console.WriteLine("Graph Vertex is Full");
                    return;
                }
                vertices[size++] = name;
            }

            // * 선의 값 변경 함수
            public void SetEdge(int i, int j, int value)
            {
                adjMat[i, j] = value;
            }

            // * 간선 삽입
            public void InsertEdge(int u, int v)
            {
                SetEdge(u, v, 1);
                SetEdge(v, u, 1);
            }

            // * 그래프 요소 출력
            public void Display()
            {
                Console.WriteLine("Vertex Size : " + size);
                Console.Write("    "); //4칸 띄워줌

                for (int i = 0; i < size; i++)
                {
                    Console.Write(GetVertex(i) + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < size; i++)
                {
                    Console.Write(GetVertex(i) + " : ");
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(GetEdge(i, j) + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main1(string[] args)
        {
            // * 그래프
            //- 요소들이 복잡하게 연결되어 있는 관계를 표현하는 자료구조
            //- 요소들이 복잡하게 연결되어 잇는 관계를 표현하는 자료구조
            //- 비선형 자료구조
            //- 정점(Vertex)과 간선(Edge)의 집합으로 구성
            //- 지하철 노선도, 네비게이션, 길찾기 등 실생활의 다양한 분야에서 사용

            // * 그래프 종류
            //1. 무방향 그래프
            //- 두 정점을 연결하는 간선에 방향이 없는 그래프
            //- 양방향 이동 가능
            //2. 방향 그래프
            //- 두 정점을 연결하는 간선에 방향이 있는 그래프
            //- 간선의 방향으로만 이동 가능
            //3. 가중치 그래프
            //- 간선에 비용 또는 가중치가 할당된 그래프
            //4. 완전 그래프
            //- 모든 정점간에 간선이 존재하는 그래프
            //- 무방향 완전그ㅐㄹ프의 정점의 수가 n이라면
            //- 간선의 수는 n*(n-1)/2가 된다.

            // * 그래프 용어
            //1. 정점(Vertex)
            //- 노드(Node)라 불리며 데이터가 저장되는 그래프의 기본 원소
            //2. 간선(Edge)
            //- 링크(Link)라고도 부르며 정점간의 관계를 나타냄
            //3. 차수(Degree)
            //- 정점에 연결된 간선의 수
            //4. 인접정점(Adjacent Vertex)
            //- 하나의 정점에서 간선에 의해 연결되어 있는 정점
            //5. 경로(Path)
            //- 간선을 따라갈 수 있는 길을 의미
            //6. 경로의 길이(Length)
            //- 경로를 구성하는데 사용된 간선의 수
            //7. 사이클(Cycle)
            //- 시작정점과 종료 정점이 같은 단순 경로
            //8. 단순경로(Simple Path)
            //- 경로중에서 반복되는 간선이 없는 경로

            Graph graph = new Graph();
            graph.InsertVertex("A"); //0
            graph.InsertVertex("B"); //1
            graph.InsertVertex("C"); //2
            graph.InsertVertex("D"); //3

            graph.InsertEdge(0, 1); //A와 B를 연결
            graph.InsertEdge(1, 3); //B와 D를 연결
            graph.InsertEdge(2, 0); //C와 A를 연결
            graph.InsertEdge(3, 2); //D와 C를 연결

            graph.Display();
        }
    }
}
