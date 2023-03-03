using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _102_Orthography
    {
        // * 코딩표기법
        //- 혼자할 경우 중요하지 않지만 협업시 중요한 요소
        //- 일관성 있는 규칙으로 팀원에게 빠른 이해가 가능하도록 함
        //- 코드의 유지보수가 용이해짐

        //1. 카멜표기법
        //- 단어의 첫글자는 소문자, 이후 단어는 대문자를 사용
        //ex)playerPosition
        //ex)enemyLocation
        //ex)cameraDotLight

        //2. 파스칼 표기법
        //- 모든 단어의 첫글자를 대문자로 사용
        //ex)CreateEnemy
        //ex)OnMouseDown

        //3. 헝가리안 표기법
        //- 변수 앞에 데이터 타입을 표기
        //ex)bAttack (bool형)
        //ex)fDefence (float형)
        //ex)m_nCount (멤버변수 int형)
        //ex)m_strName(멤버변수 string형)

        //4. 스네이크 표기법
        //- 단어를 "_"로 구분하며 소문자로 표기
        //ex)enemy_position
        //ex)player_distance_target
        
        // * 사용용도
        //1). 파스칼표기법 : 클래스명, 함수명, 파일명

        //2). 카멜, 헝거리 표기법 : 변수명

        //3). bool형 변수는 앞에 is를 사용(헝가리를 b)
        //ex)bool isAttack;
        //ex)bool isReward;

        //4). 열겨형은 대문자만을 사용
        //ex) enum PLAYER_STATE {IDLE, MOVE, ATTACK, DIE}

        //5). 인터페이스는 이름 앞에 I를 붙임
        //ex) interface IObserver{}
        //ex) interface IGround{}

        //6). 하나의 클래스가 길어진다면 partial를 사용

        //7). 함수명과 변수명은 기능을 알 수 있는 명확한 단어를 사용
        //- 예외적으로 반복문은 i, j, k변수명을 사용

        //8). 계산을 할 경우 논리적으로()가 필요없어도 ()를 넣어준다.
        //ex) result = a + (b * 2);

        //9). 주의가 필요한 함수나 이슈는 주석을 달아준다.

        //10). 위의 코딩표기법은 정해진것이 아니며 팀원간의 협의하에 변경될 수 있다.
    }
}
