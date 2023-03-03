using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netmable; //네임스페이스의 제한을 풀어줌

namespace C_SharpByeong
{
    class _101_NameSpace
    {
        static void Main1(string[] args)
        {
            // * 네임스페이스
            //- 이름공간이라는 뜻
            //- 식별자(변수명, 클래스명, 함수명 등)의 고유함을 보장

            Nexon.TeamA teamA = new Nexon.TeamA();
            teamA.currentHp = 10;

            TeamA teamAA = new TeamA();
            teamAA.speed = 10;
        }
    }
}

//넥슨의 a팀
namespace Nexon
{
    class TeamA
    {
        public int currentHp; //x가 만든 변수
    }
    
}

namespace Netmable
{
    //넷마블의 A팀
    class TeamA
    {
        public int speed;
    }
}