﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _098_Asynchron
    {
        // * 동기프로그래밍
        //- 프로그램 실행 도중 어떤 작업을 요청하면
        //- 그 작업이 종료될때까지 기다렸다가 다음 작업을 진행
        //- 요청과 결과가 동시에 일어남
        //- 설계가 매우 직관적이며 간단하지만 작업완료까지 기다려야 함

        // * 비동기 프로그래밍
        //- 프로그램 실행 중 작업을 요청하면 결과를 기다리지 않고 다음 작업 실행
        //- 요청작업이 오래걸려도 다른작업을 진행할 수 있다.
        //- 설계가 복잡하다.
        
        // * 프로세스
        //- 메모리에 올라와 실행되고 있는 프로그램의 인스턴스
        //- 운영체제로부터 시스템 자원을 할당받는 작업의 단위
        //- 동적인 개념으로는 실행된 프로그램을 의미
        //- 1개의 프로세스당 1개의 스레드를 가지고 있다.

        // * 스레드
        //- 프로세스 내 실행되고 있는 여러 흐름의 단위
        //- 프로세서가 할당받은 자원을 이용하는 실행의 단위
        
        // * 멀티프로세스
        //- 하나의 응용프로그램을 여러개의 프로세스로 구성하여 각 프로세스가 하나의 작업을 처리
        //- 장점 : 여러개의 프로세스 중 하나가 문제생겨도 다른영향이 확산되지 않는다.
        //- 단점 : 캐쉬 메모리 초기화 등 무거운 작업이 진행되며 오버헤드현상이 발생할 수 있다.

        // * 멀티 스레드
        //- 여러개의 스레드로 구성하여 작업을 처리
        //- 장점1 : 시스템 자원 소모 감소(자원의 효율성 증대)
        //- 장점2 : 시스템 처리량 증가(처리 비용 감소)
        //- 단점1 : 주의 깊은 설계가 필요
        //- 단점2 : 자원 공유 문제 발생
        //- 단점3 : 디버깅이 까다롭다.

        void Test()
        {
            int x = 2;
            x += 3; //스레드 A
            x += 4; //스레드 B
            //기대하는 결과 : 9

            //멀티스레드로 제대로 실행되는 경우
            //컴퓨터 내부적으로는 이런식으로 작동 됨
            x += 3;
            int temp = x;
            temp = temp + 3;
            x = temp;

            //ex)제대로 실행되지 않는 경우
            x = 2;
            //스레드1
            int tempA = x; //tempA = 2
            tempA = tempA + 3; //tempA = 5
            //스레드2
            int tempB = x; //tempB = 2
            tempB = tempB + 4; //tempB = 6
            //스레드1
            x = tempA; //x = 5
            //스레드2
            x = tempB; //x = 6

        }

    }
}
