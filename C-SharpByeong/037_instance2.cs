using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class Warrior
    {
        public int atk = 10;
        public float speed = 10.0f;
        public string job = "Warrior";
    }
    class _037_instance2
    {
        static void Main1(string[] args)
        {
            Warrior warrior = new Warrior();
            //인스턴스 생성과 동시에 초기값이 할당됨
            Console.WriteLine("공격력 : " + warrior.atk);
            Console.WriteLine("이동속도 : " + warrior.speed);
            Console.WriteLine("직업 : " + warrior.job);

        }
    }
}
