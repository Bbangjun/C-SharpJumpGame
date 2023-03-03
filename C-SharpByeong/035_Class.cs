using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _035_Class
    {
        class Player
        {
            // * 멤버 변수
            public static int Lv = 0;
            public static string name;
            public static int damage;
            public static int defence;
            public static float speed;
            public static int exp = 0;
            public static int Maxexp = 10;

            // * 멤버 함수
            public void Print()
            {
                Console.Clear();
                Console.WriteLine("당신의 정보");
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("공격력 : " + damage);
                Console.WriteLine("방어력 : " + defence);
                Console.WriteLine("이동속도 : " + speed);
                Console.WriteLine("\n\n\n");
            }

        } //클래스 정의(기능을 만든다)
        
        //플레이어 정보
        class Paladin
        {
            // * 멤버 변수
            public static int Lv = 0;
            public static string name;
            public static int damage;
            public static int defence;
            public static float speed;
            public static int exp = 0;
            public static int Maxexp = 10;
            public double percent;
            // * 멤버 함수
            public static void Print()
            {
                Console.Clear();
                Console.WriteLine("당신의 정보");
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("공격력 : " + damage);
                Console.WriteLine("방어력 : " + defence);
                Console.WriteLine("이동속도 : " + speed);
                Console.WriteLine("경험치");
                for (int i = 1; i < 10 + 1; i++)
                {
                    if(i<=exp)
                    {
                        Console.Write("■");
                    }
                    else if(i>exp)
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine("\n\n\n");
            }

        } //클래스 정의(기능을 만든다)

        //몬스터
        class Monster
        {
            public string name;
            public int damage;
            public int defence;
            public float speed;
            public int exp;

            public void Print()
            {
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("공격력 : " + damage);
                Console.WriteLine("방어력 : " + defence);
                Console.WriteLine("이동속도 : " + speed);
            }
        }

        //몬스터 정보 표기
        class Info
        {
            public string name;
            public int damage;
            public int defence;
            public float speed;

            public void SetInfo(string name, int damage, int defence, float speed)
            {
                this.name = name;
                this.damage = damage;
                this.defence = defence;
                this.speed = speed;
            }
            public void GetInfo()
            {
                Console.WriteLine("=========================");
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("공격력 : " + damage);
                Console.WriteLine("방어력 : " + defence);
                Console.WriteLine("이동속도 : " + speed);
                Console.WriteLine("=========================");
            }
        }

        static public int Menu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("1. 캐릭터 정보");
            Console.WriteLine("2. 전투");
            Console.WriteLine("3. 종료");
            Console.WriteLine("================================");
            Console.WriteLine("원하는 값을 입력하세요.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && input < 4)
            {
                return input;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("값이 잘못되었습니다. 다시입력해주세요");
                Menu();
            }
            return 0;
            
        }

        static public void Back()
        {
            Console.WriteLine("뒤로가시려면 아무키나 입력하세요.");
            Console.ReadLine();
            Console.Clear();
        }

        public static bool Fight(int Adamage, int Bdamage, int Adefence, int Bdefence)
        {
            if ((Adamage - Bdefence) > (Bdamage - Adefence))
            {
                Console.WriteLine("승리");
                return true;
            }
            else
            {
                Console.WriteLine("패배");
                return false;
            }
        }

        public static bool Exp(int exp, int MaxExp)
        {
            if(exp >= MaxExp)
            {
                Console.WriteLine("레벨 업");
                return true;
            }
            return false;
        }

        static void Main1(string[] args)
        {

            // * class
            //- 변수와 함수의 모음
            //- 사용자 정의 자료형
            //- Reference Type
            //- 객체지향의 4대속성을 지원

            // * 클래스의 4대 속성
            //- 캡슐화 : 관련있는 데이터와 기능을 묶음
            //- 상속성 : 공통된 요소를 자식에게 물려줌
            //- 다형성 : 다른 객체가 동일한 메세지를 통해 각기다른 가능을 수행
            //- 추상성 : 공통적인 부분, 특정 특성을 분리해 재조합


            //Player Wizard;
            //Wizard.name = "위자드"; // 인스턴스화를 해야 한다

            // * 실습
            //- Monster 클래스 만들기
            //- 멤버변수, 멤버함수 만들기
            //- Monster객체 3개 만들기
            //- 객체 1개만 정보를 출력

            Monster Rat = new Monster();
            Rat.name = "쥐";
            Rat.damage = 3;
            Rat.defence = 5;
            Rat.speed = 8;
            Rat.exp = 3;

            Monster Slime = new Monster();
            Slime.name = "슬라임";
            Slime.damage = 5;
            Slime.defence = 7;
            Slime.speed = 5;
            Slime.exp = 5;

            Monster Zombie = new Monster();
            Zombie.name = "좀비";
            Zombie.damage = 15;
            Zombie.defence = 10;
            Zombie.speed = 7;
            Zombie.exp = 7;

            Player Warrior = new Player(); //클래스를 변수선언하면 null값이 들어간다. //인스턴스화


            Paladin.name = "팔라딘";
            Paladin.damage = 10;
            Paladin.defence = 10;
            Paladin.speed = 12.34f;

            bool Victory;

            while (true)
            {
                if (Exp(Paladin.exp, Paladin.Maxexp))
                {
                    Paladin.damage += 2;
                    Paladin.defence += 1;
                    Paladin.Lv += 1;
                    Paladin.exp -= Paladin.Maxexp;
                    Paladin.Maxexp += 5;
                    Console.WriteLine();
                }
                int input = Menu();
                switch(input)
                {
                    case 1:
                        Paladin.Print();
                        Back();
                        break;
                    case 2:
                        Console.Clear();
                        Info info = new Info();
                        info.SetInfo(Rat.name, Rat.damage, Rat.defence, Rat.speed);
                        info.GetInfo();
                        info.SetInfo(Slime.name, Slime.damage, Slime.defence, Slime.speed);
                        info.GetInfo();
                        info.SetInfo(Zombie.name, Zombie.damage, Zombie.defence, Zombie.speed);
                        info.GetInfo();


                        Console.WriteLine("전투 대상을 선택하세요, 1.쥐 2.슬라임 3.좀비");
                        int FightNum = Convert.ToInt32(Console.ReadLine());

                        switch (FightNum)
                        {
                            case 1:
                                Victory = Fight(Paladin.damage, Rat.damage, Paladin.defence, Rat.defence);
                                if (Victory)
                                {
                                    Paladin.exp += Rat.exp;
                                }
                                break;
                            case 2:
                                Victory = Fight(Paladin.damage, Slime.damage, Paladin.defence, Slime.defence);
                                if (Victory)
                                {
                                    Paladin.exp += Slime.exp;
                                }
                                break;
                            case 3:
                                Victory = Fight(Paladin.damage, Zombie.damage, Paladin.defence, Zombie.defence);
                                if (Victory)
                                {
                                    Paladin.exp += Zombie.exp;
                                }
                                break;
                        }

                        Back();
                        break;
                    case 3:
                        break;
                }
                if (input == 3)
                    break;
            }

            
           
            

            

            

        }
       
    }
}

// * 절차지향
//- 순서적인 처리가 중요시 됨
//- 흐름도같은 개념
//- 절차적으로 코드를 구성

// * 객체지향
//- 데이터와 함수를 묶어서 객체로 만들어서 사용
//- 캡슐화, 다형성, 상속성, 추상성을 지원
//- 데이터 접근 제한 기능(보안과는 무관한 기능)

// * 절차지향과 객체지향
//- 객체지향도 절차지향적으로 프로그래밍이 가능
//- 둘은 프로그래밍 접근방법이 상이할 뿐 정 반대개념은 아님

