using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _077_GenericList
    {
        static void Main1(string[] args)
        {
            // * 컬렉션
            //- 자료구조를 구현한 클래스
            //- Object 타입으로 값을 저장한다.

            // * 제네릭 컬렉션
            //- 자료형이 지정되어 Boxing, Unboxing과정이 일어나지 않는다.

            // * 리스트(연결리스트)
            //- 크기가 가변적(변할 수 있다)
            //- 어디든 데이터를 넣고 뺄 수 있다.
            //- 빈 공간 없이 유지 됨

            List<int> list = new List<int>();
            list.Add(10); //10의 데이터 추가
            list.Add(20);
            list.Add(30);
            list.Add(80);
            list.Add(50);

            list[1] = 99;            
            list.RemoveAt(0); //0번째 인덱스 제거

            list.Reverse(); //순서 뒤집기

            list.Sort();

            list.Insert(2, 77); //Insert(n, m) n번째 인덱스에 m값을 추가 기존 n번째 인덱스는 n+1인덱스로 넘어감

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");
            // * 실습
            //- float형으로 리스트를 만ㄷ르고
            //- 값을 추가한 후
            //- 내림차순정렬 한 다음 출력

            List<float> Flist = new List<float>();
            Flist.Add(1.1f);
            Flist.Add(2.2f);
            Flist.Add(3.3f);

            Flist.Insert(1, 1.5f);
            Flist.Sort();
            Flist.Reverse();
            
            foreach(var item in Flist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
