using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class Vector
    {
        public float x;
        public float y;
        public float z;

        public Vector(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public String ToString()
        {
            return "x : " + x + " y : " + y + " z : " + z;
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return v1.x != v2.x && v1.y != v2.y && v1.z != v2.z;
        }
    }


    class _091_OperatorOverload
    {
        static void Main1(string[] args)
        {
            // * 연산자 오버로딩
            //- 연산자를 재정의 하는 것

            // * 연산자 오버로딩 규칙
            //- 기존에 없는 새로운 연산자는 재정의 불가(**, %*, ^&, @, 등등)
            //- 단항 또는 이항연산자로 오버로드 가능
            //- 멤버함수로 오버로드 된 연산자의 첫번째 파라미터는 항상
            //  연산자가 호출되는 객체 클래스

            Vector vec1 = new Vector(1, 2, 3);
            Vector vec2 = new Vector(4, 5, 6);
            Vector result = vec1 + vec2;
            Console.WriteLine(result.ToString());

            // * 실습
            //- Vector클래스에 빼기(-)연산자 오버로딩 만들기
            //- 곱하기(*)연산자 오버로딩 만들기
            result = vec1 - vec2;
            Console.WriteLine(result.ToString());
            result = vec1 * vec2;
            Console.WriteLine(result.ToString());

            bool compare;
            compare = vec1 == vec2;
            Console.WriteLine(compare);
            compare = vec1 != vec2;
            Console.WriteLine(compare);
        }
    }
}
