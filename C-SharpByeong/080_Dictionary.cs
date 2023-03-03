using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_SharpByeong
{
    class _080_Dictionary
    {
        static void Main1(string[] args)
        {
            // * 딕셔너리
            //- 해쉬테이블의 제네릭 컬렉션

            // * 해쉬테이블
            //- 배열, 리스트는 요소에 접근할 경우 인덱스를 사용
            //- HashTable은 요소에 접근할때 지정된 키를 사용
            //- 키(Key)값을 이용하여 데이터를 추가 및 사용

            // * 해시(Hash)
            //- 데이터값을 다른값과 1:1대응시키는 것
            //- Key1을 value1에, Key2를 value2에 연결

            // * 해쉬테이블(컬렉션)
            Hashtable hash = new Hashtable();
            hash.Add("Apple", 50); //Apple이라는 키로 50의 값 추가

            Console.WriteLine(hash["Apple"]);

            hash.Add(30, 12.34f);
            Console.WriteLine(hash[30]);

            hash.Add("네이버", "www.naver.com");
            Console.WriteLine(hash["네이버"]);

            List<int> data = new List<int>();
            data.Add(10); //힘
            data.Add(13); //민첩
            data.Add(40); //지능
            data.Add(50); //행운
            Console.WriteLine("지능 : " + data[2]);
            //가독성이 좋지 않음

            // * 딕셔너리
            //- 해쉬테이블의 제네릭 컬렉션 버전
            //- 키와 데이터의 자료형을 지정해야한다.

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("힘", 23);
            dic.Add("민첩", 55);
            dic.Add("지능", 74);
            dic.Add("행운", 33);

            Console.WriteLine("힘 : " + dic["힘"]);
            Console.WriteLine("민첩 : " + dic["민첩"]);

            // * 실습
            //- 딕셔너리를 객체를 새로 만든 후
            //- 값 3개 추가 후 3개를 출력

            Dictionary<string, float> dict = new Dictionary<string, float>();
            dict.Add("이동속도", 5.5f);
            dict.Add("공격배율", 1.0f);
            dict.Add("공격속도", 1.1f);

            Console.WriteLine("이동속도 : " + dict["이동속도"]);
            Console.WriteLine("공격배율 : " + dict["공격배율"]);
            Console.WriteLine("공격속도 : " + dict["공격속도"]);

        }
    }
}
