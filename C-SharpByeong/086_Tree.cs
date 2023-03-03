using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _086_Tree
    {
        class Node
        {
            public int data; // 데이터
            public Node left;
            public Node right;
        }

        static Node CreateNode(int data)
        {
            Node node = new Node();//노드 생성
            node.data = data;
            node.left = null;
            node.right = null;
            return node;
        }

        static void Main1(string[] args)
        {
            // + 트리
            //- 비선형 자료구조
            //- 계층적 자료구조이며 계층형성 정보 저장을 위해 사용
            //- 정보검색을 쉽게 만들어줌

            // * 트리 용어
            //- Node : 트리 구조의 요소(Element)
            //- 루트(Root) 노드 : 최상위 노드
            //- 브런치(Branch) 노드 : 중간에 있는 노드
            //- 잎(Leaf)노드 : 가장 마지막에 있는 노드
            //- 부모 노드 : 현재노드 바로 위에 노드
            //- 자식 노드 : 현재노드 바로 아래 노드

            Node root = CreateNode(1);
            root.right = CreateNode(2);
            root.left = CreateNode(3);
            root.right.right = CreateNode(4);
            root.right.left = CreateNode(5);
            root.left.left = CreateNode(6);
            root.right.left.right = CreateNode(7);


        }
    }
}
