using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _083_ArrayLinkedList
    {
        // * 노드(node)
        //- 자료구조에서 데이터가 저장되는 기본 원소
        class Node
        {
            public int data;
            public Node next;
            public Node(int _data)
            {
                data = _data;
                next = null;
            }
        }

        class LinkedList //연결리스트 클래스
        {
            Node head; //첫번째 노드

            // * 마지막 노드를 구하는 함수
            public Node GetLastNode()
            {
                Node temp = head;
                while(temp.next != null) //값이 없을때까지 반복
                {
                    temp = temp.next; //다음노드를 temp에 저장
                }
                return temp; //마지막노드를 반환
            }

            // * 맨앞에 노드를 추가하는 함수
            public void InsertFront(int data)
            {
                Node node = new Node(data);
                node.next = head; //맨앞 노드를 다음노드로
                head = node; //새로 생성한 노드를 맨 앞으로
            }

            // * 맨 뒤에 노드 추가 함수
            public void InsertLast(int data)
            {
                Node node = new Node(data);
                if(head == null) //값이 없다면
                {
                    head = node; //맨 앞에 새로 생성한 노드를 추가
                    return; //함수 종료
                }
                Node lastNode = GetLastNode();
                lastNode.next = node;
            }
            public void Insert(int index, int data)
            {
                Node tempNode = head;
                for (int i = 0; i < index; i++)
                {
                    if (tempNode == null) return; //함수 종료
                    tempNode = tempNode.next; //옆으로 이동
                }
                Node node = new Node(data); //노드 생성
                node.next = tempNode.next; //생성노드 옆으로 이동
                tempNode.next = node; //중간에 추가
            }
            public void Delete(int key)
            {
                Node temp = head;
                Node prev = null;
                if(temp.data == key) //첫 노드가 값과 같다면
                {
                    head = temp.next; //첫노드 제거
                    return;
                }
                while(temp.data != key)
                {
                    prev = temp; //상위 노드를 prev에 넣음
                    temp = temp.next; //다음노드를 temp에 넣어줌
                }
                prev.next = temp.next; //하위노드를 상위노드에 넣어줌
            }

            public void Display()
            {
                for(Node node = head; node != null; node = node.next)
                {
                    Console.Write(node.data + "->");
                }
                Console.WriteLine();
            }
        }
        static void Main1(string[] args)
        {
            LinkedList list = new LinkedList();
            list.InsertFront(10);
            list.InsertFront(20);
            list.InsertLast(30);
            list.Insert(1, 50);
            list.Display();
            list.Delete(10);
            list.Display();
        }
    }
}
