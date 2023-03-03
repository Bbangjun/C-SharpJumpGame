using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _090_Random
    {
        static void Main1(string[] args)
        {
            // * 난수
            //- 특정한 순서나 규칙을 가지지 않는 수

            Random rnd = new Random();
            int random = rnd.Next();
            //Next() : 랜덤한 난수를 반환
            //범위 : 0~약21억까지
            Console.WriteLine(random);

            random = rnd.Next(100);
            //Next(maxValue) : 0~maxValue까지의 값을 반환
            Console.WriteLine(random);

            random = rnd.Next(50, 150);
            //Next(min, max) : min ~ max 까지의 난수를 반환
            Console.WriteLine(random);

            Console.WriteLine(rnd.NextDouble());
            //NextDouble() : 부동소수점 난수를 반환
            //범위 : 0.0 ~ 1.0

            // * 실습
            //- NextDouble함수를 사용하여
            //- 1. 0~10까지의 난수를 출력
            //- 2. 5~10까지의 난수를 출력

            //- NextDouble함수는 인자가 들어가지 않는다.

            double value = 0;

            value = rnd.NextDouble()* 10;
            Console.WriteLine(value);
            value = rnd.NextDouble()*5 + 5 ;
            Console.WriteLine(value);
        }
    }
}
