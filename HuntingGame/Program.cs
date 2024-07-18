using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HuntingGame
{

    public enum ItemType
    {
        장비아이템, 기타, 골드환산아이템
    }
    public enum ItemGrade
    {
        Epic, Rare, Common
    }
    public struct Item
    {
        public string itemName;
        public ItemType type;
        public ItemGrade grade;
        public int itemPrice;
    }




    internal class Program
    {


        static void Inventory()
        {
            int[] inventory = new int[4];
            inventory[0] = 0;
            inventory[1] = 0;
            inventory[2] = 0;
            inventory[3] = 0;

            int[] itemCount = new int[4];
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"        신성한 검: \t{itemCount[0]}개");
            Console.WriteLine($"        저주받은 도끼: \t{itemCount[1]}개");
            Console.WriteLine($"        맛있는 빵: \t{itemCount[2]}개");
            Console.WriteLine($"        금화 무더기: \t{itemCount[3]}개");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                PRESS ANY KEY");
            Console.ReadKey();
        }

        static void ItemCount(ref int Count)
        {
            Console.Clear();
            int swordCount = 0;
            swordCount = swordCount += 1;
            int axeCount = 0;
            int etcCount = 0;
            int goldCount = 0;

            int[] itemCount = new int[4];
            Console.WriteLine($"신성한 검: {itemCount[0] = swordCount}개");
            Console.WriteLine($"저주받은 도끼: {itemCount[1] = axeCount}개");
            Console.WriteLine($"맛있는 빵{itemCount[2] = etcCount}개");
            Console.WriteLine($"금화 무더기{itemCount[3] = goldCount}개");
            Console.WriteLine("         PRESS ANY KEY");
            Console.ReadKey();
        }





        static void HolySword()
        {
            Item Holysword = new Item()
            {
                itemName = "신성한 검",
                type = ItemType.장비아이템,
                grade = ItemGrade.Epic,
                itemPrice = 5000,
            };
            Console.WriteLine($"아이템명: {Holysword.itemName}");
            Console.WriteLine($"아이템 종류: {Holysword.type}");
            Console.WriteLine($"아이템 등급: {Holysword.grade}");
            Console.WriteLine($"아이템 가치: {Holysword.itemPrice}");
            Console.WriteLine();

        }
        static void CursedAxe()
        {
            Item Cursedaxe = new Item();
            Cursedaxe.itemName = "저주받은 도끼";
            Cursedaxe.type = ItemType.장비아이템;
            Cursedaxe.grade = ItemGrade.Rare;
            Cursedaxe.itemPrice = 3000;

            Console.WriteLine($"아이템명: {Cursedaxe.itemName}");
            Console.WriteLine($"아이템 종류: {Cursedaxe.type}");
            Console.WriteLine($"아이템 등급: {Cursedaxe.grade}");
            Console.WriteLine($"아이템 가치: {Cursedaxe.itemPrice}");
            Console.WriteLine();
        }
        static void Bread()
        {
            Item Bread = new Item();
            Bread.itemName = "맛있는 빵";
            Bread.type = ItemType.기타;
            Bread.grade = ItemGrade.Common;
            Bread.itemPrice = 100;

            Console.WriteLine($"아이템명: {Bread.itemName}");
            Console.WriteLine($"아이템 종류: {Bread.type}");
            Console.WriteLine($"아이템 등급: {Bread.grade}");
            Console.WriteLine($"아이템 가치: {Bread.itemPrice}");
            Console.WriteLine();
        }
        static void Gold()
        {
            Item Gold = new Item();
            Gold.itemName = "금화 무더기";
            Gold.type = ItemType.골드환산아이템;
            Gold.grade = ItemGrade.Common;
            Gold.itemPrice = 500;

            Console.WriteLine($"아이템명: {Gold.itemName}");
            Console.WriteLine($"아이템 종류: {Gold.type}");
            Console.WriteLine($"아이템 등급: {Gold.grade}");
            Console.WriteLine($"아이템 가치: {Gold.itemPrice}");
            Console.WriteLine();
        }



        static void Start()
        {
            Console.WriteLine("    ■      ■   ■     ■    ■     ■   ■■■■■■  ■■■■■      ■■■  ");
            Console.WriteLine("    ■      ■   ■     ■    ■■   ■       ■■      ■              ■   ■ ");
            Console.WriteLine("    ■■■■■   ■     ■    ■ ■  ■       ■■      ■■■■■      ■■■  ");
            Console.WriteLine("    ■      ■   ■     ■    ■   ■■       ■■      ■              ■   ■ ");
            Console.WriteLine("    ■      ■    ■■■■    ■     ■       ■■      ■■■■■      ■    ■ ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                        Press any Key                         ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");

            Console.ReadKey();

        }

        static void SelectBehavior()
        {
            Console.Clear();
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                   할 행동을 선택해주세요.                      ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    (1. [권장] 전투 설명을 듣는다 [권장])      ");
            Console.ResetColor();
            Console.WriteLine("    (2. 몬스터를 사냥한다)                                ");
            Console.WriteLine("    (3. 다른 사람을 찾아 나선다)                                          ");
            Console.WriteLine("    (4. 가방을 확인한다)                                    ");
            Console.WriteLine("    (5. 로그아웃 한다)                                   ");

        }
        static void Tutorial()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     HUNTER 는 로그라이크 게임입니다.    ");
            Console.WriteLine("     상대방의 공격에 맞춰 올바른 동작을 입력하면   ");
            Console.WriteLine("     공격을 회피할 수 있습니다.    ");
            Console.WriteLine("     한 전투에서 2회 이상 피격당하면 패배하며,   ");
            Console.WriteLine("     모든 공격을 방어하고 나면 역습을 가하여 승리합니다.   ");
            Console.WriteLine("                                                       ");
            Console.WriteLine("     좌로 구르기 >  Press ←   ");
            Console.WriteLine("     우로 구르기 >  Press →  ");
            Console.WriteLine("     방패로 방어하기 >  Press ↓");
            Console.WriteLine("                    PRESS ANY KEY");
            Console.ReadKey();

        }

        static void MonsterHuntStart()
        {
            Console.Clear();
            Console.WriteLine("                                                              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         몬스터가 나타났습니다. 전투를 준비해주세요.              ");
            Console.ResetColor();
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                      ㅁㅁ    ㅁㅁ                             ");
            Console.WriteLine("                        ㅁㅁㅁㅁ                               ");
            Console.WriteLine("                        ㅁㅁㅁㅁ                               ");
            Console.WriteLine("                  ㅁ  ㅁ  ㅁㅁ  ㅁ  ㅁ                         ");
            Console.WriteLine("                    ㅁ    ㅁㅁ    ㅁ                           ");
            Console.WriteLine("                  ㅁ      ㅁㅁ      ㅁ                         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                              ");
            Console.WriteLine("                      Press any Key                           ");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void MonsterHuntBattle1()
        {

            bool tf;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("             ㅁ   ㅁ  ㅁㅁ    ㅁㅁ                             ");
                Console.WriteLine("                  ㅁ    ㅁㅁㅁㅁ                               ");
                Console.WriteLine("                    ㅁ  ㅁㅁㅁㅁ                               ");
                Console.WriteLine("                      ㅁ  ㅁㅁ  ㅁ  ㅁ                         ");
                Console.WriteLine("                          ㅁㅁ    ㅁ                           ");
                Console.WriteLine("                          ㅁㅁ      ㅁ                         ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("   1. 좌로 구르기 2.가드 3. 우로 구르기                          ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Console.WriteLine("                                                              ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 공격 회피에 성공하였습니다!!                   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("다음 공격이 옵니다 !");
                        Console.ResetColor();
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                      ㅁㅁ    ㅁㅁ   ㅁ ㅁ                       ");
                        Console.WriteLine("                        ㅁㅁㅁㅁ     ㅁ                       ");
                        Console.WriteLine("                        ㅁㅁㅁㅁ   ㅁ                           ");
                        Console.WriteLine("                       ㅁ ㅁㅁ  ㅁ                             ");
                        Console.WriteLine("                     ㅁ   ㅁㅁ                                 ");
                        Console.WriteLine("                  ㅁ ㅁ   ㅁㅁ                                 ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                      PRESS ANY KEY");
                        Console.ResetColor();
                        Console.ReadKey();
                        tf = false;
                        break;

                    default:
                        //case ConsoleKey.DownArrow:
                        //case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       D  I   E                                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("          공격 방어에 실패하여 몸이 찢어져 죽었습니다.    ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                       THE END                                 ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("         HINT 측면에서 오는 공격은 방향에 맞춰 회피해보세요        ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;

                }

            } while (tf == true);
        }
        static void MonsterHuntBattle2()
        {

            bool tf;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                      ㅁㅁ    ㅁㅁ   ㅁ ㅁ                       ");
                Console.WriteLine("                        ㅁㅁㅁㅁ     ㅁ                       ");
                Console.WriteLine("                        ㅁㅁㅁㅁ   ㅁ                           ");
                Console.WriteLine("                       ㅁ ㅁㅁ  ㅁ                             ");
                Console.WriteLine("                     ㅁ   ㅁㅁ                                 ");
                Console.WriteLine("                  ㅁ ㅁ   ㅁㅁ                                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("   1. 좌로 구르기 2.가드 3. 우로 구르기                          ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.WriteLine("                                                              ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 공격 회피에 성공하였습니다!!                   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                    다음 공격이 옵니다 !");
                        Console.ResetColor();
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("              ㅁ  ㅁ  ㅁㅁ    ㅁㅁ   ㅁ ㅁ                       ");
                        Console.WriteLine("                  ㅁ    ㅁㅁㅁㅁ     ㅁ                       ");
                        Console.WriteLine("                    ㅁ  ㅁㅁㅁㅁ   ㅁ                           ");
                        Console.WriteLine("                       ㅁ ㅁㅁ  ㅁ                             ");
                        Console.WriteLine("                          ㅁㅁ                                 ");
                        Console.WriteLine("                          ㅁㅁ                                 ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                      PRESS ANY KEY");
                        Console.ResetColor();
                        Console.ReadKey();
                        tf = false;
                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       D  I   E                                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("          공격 방어에 실패하여 몸이 찢어져 죽었습니다.    ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                       THE END                                 ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("         HINT 측면에서 오는 공격은 방향에 맞춰 회피해보세요        ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;

                }

            } while (tf == true);
        }
        static void MonsterHuntBattle3()
        {

            bool tf;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("              ㅁ  ㅁ  ㅁㅁ    ㅁㅁ   ㅁ ㅁ                       ");
                Console.WriteLine("                  ㅁ    ㅁㅁㅁㅁ     ㅁ                       ");
                Console.WriteLine("                    ㅁ  ㅁㅁㅁㅁ   ㅁ                           ");
                Console.WriteLine("                       ㅁ ㅁㅁ  ㅁ                             ");
                Console.WriteLine("                          ㅁㅁ                                 ");
                Console.WriteLine("                          ㅁㅁ                                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("   1. 좌로 구르기 2.가드 3. 우로 구르기                          ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Console.WriteLine("                                                              ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 공격 방어에 성공하였습니다!!                   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("    적이 무방비 상태입니다. 아무 키나 눌러서 적을 마무리하세요");
                        Console.ResetColor();
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                      ㅁㅁ    ㅁㅁ                               ");
                        Console.WriteLine("                        ㅁㅁㅁㅁ                              ");
                        Console.WriteLine("               ㅁ       ㅁㅁㅁㅁ        ㅁ                      ");
                        Console.WriteLine("               ㅁ ㅁ ㅁㅁ ㅁㅁ  ㅁ ㅁ ㅁ ㅁ                   ");
                        Console.WriteLine("               ㅁ         ㅁㅁ         ㅁ                      ");
                        Console.WriteLine("                          ㅁㅁ                                 ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                      PRESS ANY KEY                       ");
                        Console.ResetColor();
                        Console.ReadKey();
                        tf = false;
                        break;

                    default:
                        //case ConsoleKey.DownArrow:
                        //case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       D  I   E                                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("          공격 방어에 실패하여 몸이 찢어져 죽었습니다.    ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                       THE END                                 ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("         HINT 측면에서 오는 공격은 방향에 맞춰 회피해보세요        ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;

                }

            } while (tf == true);
        }
        static void MonsterHuntBattleEnd()
        {

            bool tf = true;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                  몬스터가 처치되었습니다.                      ");
                Console.WriteLine("                  아이템을 획득하였습니다.                                            ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                      ㅁㅁ    ㅁㅁ                               ");
                Console.WriteLine("                        ㅁㅁㅁㅁ                              ");
                Console.WriteLine("               ㅁ       ㅁㅁㅁㅁ        ㅁ                      ");
                Console.WriteLine("               ㅁ ㅁ ㅁㅁ ㅁㅁ  ㅁ ㅁ ㅁ ㅁ                   ");
                Console.WriteLine("               ㅁ         ㅁㅁ         ㅁ                      ");
                Console.WriteLine("                          ㅁㅁ                                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("             1. 아이템 확인 2. 메인 화면으로                         ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D1:

                        Console.Clear();
                        Console.WriteLine("    드랍 아이템 목록                                            ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        HolySword();
                        Bread();
                        Gold();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.D2:

                        Console.Clear();
                        ReturnMain();
                        tf = false;

                        break;

                }

            } while (tf == true);
        }
        static void Logout()
        {
            Console.Clear();
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                      게임을 종료합니다.                         ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                         The    END                             ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");

        }
        static void ReturnMain()
        {
            Console.Clear();
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                      메인화면으로 돌아갑니다..                         ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                         PRESS ANY KEY                          ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");

        }
        static void ManHuntStart()
        {
            Console.Clear();
            Console.WriteLine("                                                              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         사람을 조우했습니다. 전투를 준비해주세요.                ");
            Console.ResetColor();
            Console.WriteLine("                                                              ");
            Console.WriteLine("                         ㅁㅁㅁ    ㅁ                          ");
            Console.WriteLine("                        ㅁㅁㅁㅁ     ㅁ                        ");
            Console.WriteLine("                         ㅁㅁㅁ        ㅁ                      ");
            Console.WriteLine("                     ㅁㅁㅁㅁㅁㅁㅁㅁ     ㅁ                    ");
            Console.WriteLine("                          ㅁㅁ         ㅁ                      ");
            Console.WriteLine("                          ㅁㅁ       ㅁ                         ");
            Console.WriteLine("                        ㅁ    ㅁ   ㅁ                          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                              ");
            Console.WriteLine("                      Press any Key                           ");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void ManHuntBattle1()
        {

            bool tf;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                     ㅁ  ㅁㅁㅁ                               ");
                Console.WriteLine("                   ㅁ   ㅁㅁㅁㅁ                               ");
                Console.WriteLine("                 ㅁ      ㅁㅁㅁ                                ");
                Console.WriteLine("               <-ㅁ--ㅁㅁㅁㅁㅁㅁㅁㅁ                        ");
                Console.WriteLine("                 ㅁ       ㅁㅁ                                 ");
                Console.WriteLine("                   ㅁ     ㅁㅁ                                 ");
                Console.WriteLine("                     ㅁ ㅁ    ㅁ                               ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("   1. 좌로 구르기 2.가드 3. 우로 구르기                          ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.WriteLine("                                                              ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 공격 회피에 성공하였습니다!!                   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                    다음 공격이 옵니다 !");
                        Console.ResetColor();
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                         ㅁㅁㅁ   ㅁ                            ");
                        Console.WriteLine("                        ㅁㅁㅁㅁ    ㅁ                           ");
                        Console.WriteLine("                         ㅁㅁㅁ       ㅁ                         ");
                        Console.WriteLine("                     ㅁㅁㅁㅁㅁㅁㅁㅁ --ㅁ->                       ");
                        Console.WriteLine("                          ㅁㅁ        ㅁ                         ");
                        Console.WriteLine("                          ㅁㅁ      ㅁ                           ");
                        Console.WriteLine("                        ㅁ    ㅁ  ㅁ                             ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                      PRESS ANY KEY");
                        Console.ResetColor();
                        Console.ReadKey();
                        tf = false;
                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       D  I   E                                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("          공격 방어에 실패하여 화살밥이 되어 죽었습니다.    ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                       THE END                                 ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("         HINT 화살이 날아오는 방향을 잘 보고 회피해보세요        ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;

                }

            } while (tf == true);
        }

        static void ManHuntBattle2()
        {

            bool tf;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                         ㅁㅁㅁ   ㅁ                            ");
                Console.WriteLine("                        ㅁㅁㅁㅁ    ㅁ                           ");
                Console.WriteLine("                         ㅁㅁㅁ       ㅁ                         ");
                Console.WriteLine("                     ㅁㅁㅁㅁㅁㅁㅁㅁ --ㅁ->                       ");
                Console.WriteLine("                          ㅁㅁ        ㅁ                         ");
                Console.WriteLine("                          ㅁㅁ      ㅁ                           ");
                Console.WriteLine("                        ㅁ    ㅁ  ㅁ                             ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("   1. 좌로 구르기 2.가드 3. 우로 구르기                          ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Console.WriteLine("                                                              ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 공격 회피에 성공하였습니다!!                   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                    다음 공격이 옵니다 !");
                        Console.ResetColor();
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                         ㅁㅁㅁ                               ");
                        Console.WriteLine("                        ㅁㅁㅁㅁ                               ");
                        Console.WriteLine("                         ㅁㅁㅁ                                ");
                        Console.WriteLine("                     ㅁㅁㅁㅁㅁㅁㅁㅁ                        ");
                        Console.WriteLine("                          ㅁㅁ                                 ");
                        Console.WriteLine("                          ㅁㅁ                                 ");
                        Console.WriteLine("                  ㅁ    ㅁ    ㅁ   ㅁ                            ");
                        Console.WriteLine("                     ㅁ         ㅁ                ");
                        Console.WriteLine("                         ㅁㅁㅁ         ");
                        Console.WriteLine("                           ↓                                    ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                      PRESS ANY KEY");
                        Console.ResetColor();
                        Console.ReadKey();
                        tf = false;
                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       D  I   E                                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("          공격 방어에 실패하여 화살밥이 되어 죽었습니다.    ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                       THE END                                 ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("         HINT 화살이 날아오는 방향을 잘 보고 회피해보세요        ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;

                }

            } while (tf == true);
        }

        static void ManHuntBattle3()
        {

            bool tf;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                         ㅁㅁㅁ                               ");
                Console.WriteLine("                        ㅁㅁㅁㅁ                               ");
                Console.WriteLine("                         ㅁㅁㅁ                                ");
                Console.WriteLine("                     ㅁㅁㅁㅁㅁㅁㅁㅁ                        ");
                Console.WriteLine("                          ㅁㅁ                                 ");
                Console.WriteLine("                          ㅁㅁ                                 ");
                Console.WriteLine("                  ㅁ    ㅁ    ㅁ   ㅁ                            ");
                Console.WriteLine("                     ㅁ         ㅁ                ");
                Console.WriteLine("                         ㅁㅁㅁ         ");
                Console.WriteLine("                           ↓                                    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("   1. 좌로 구르기 2.가드 3. 우로 구르기                          ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Console.WriteLine("                                                              ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 공격 회피에 성공하였습니다!!                   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("    적이 무방비 상태입니다. 아무 키나 눌러서 적을 마무리하세요 !");
                        Console.ResetColor();
                        Console.WriteLine("                                                              ");
                        Console.WriteLine("                          ㅁㅁㅁ                               ");
                        Console.WriteLine("                         ㅁㅁㅁㅁ                               ");
                        Console.WriteLine("                          ㅁㅁㅁ                                ");
                        Console.WriteLine("                     ㅁㅁㅁㅁㅁㅁㅁㅁ                        ");
                        Console.WriteLine("                           ㅁㅁ                                 ");
                        Console.WriteLine("                           ㅁㅁ                                 ");
                        Console.WriteLine("                          ㅁ   ㅁ                            ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                      PRESS ANY KEY");
                        Console.ResetColor();
                        Console.ReadKey();
                        tf = false;
                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       D  I   E                                ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("          공격 방어에 실패하여 화살밥이 되어 죽었습니다.    ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                       THE END                                 ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("         HINT 화살이 날아오는 방향을 잘 보고 회피해보세요        ");
                        Console.ResetColor();
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                                                               ");
                        Console.ReadKey();
                        tf = true;

                        break;

                }

            } while (tf == true);
        }

        static void ManHuntBattleEnd()
        {

            bool tf = true;


            do
            {
                ConsoleKeyInfo key;


                Console.Clear();
                Console.WriteLine("                                                              ");
                Console.WriteLine("                  상대방이 처치되었습니다.                      ");
                Console.WriteLine("                  아이템을 획득하였습니다.                                            ");
                Console.WriteLine("                                                              ");
                Console.WriteLine("                         ㅁㅁㅁ                               ");
                Console.WriteLine("                        ㅁㅁㅁㅁ                              ");
                Console.WriteLine("                         ㅁㅁㅁ                              ");
                Console.WriteLine("                      ㅁㅁㅁㅁㅁㅁㅁ                 ");
                Console.WriteLine("                          ㅁㅁ                               ");
                Console.WriteLine("                          ㅁㅁ                                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                               ");
                Console.WriteLine("             1. 아이템 확인 2. 메인 화면으로                         ");
                Console.ResetColor();

                key = Console.ReadKey();

                switch (key.Key)
                {

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.D1:

                        Console.Clear();
                        Console.WriteLine("               드랍 아이템 목록  ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        CursedAxe();
                        Gold();
                        Gold();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("              PRESS ANY KEY");
                        Console.ReadKey();
                        tf = true;

                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D2:

                        Console.Clear();
                        ReturnMain();
                        tf = false;

                        break;

                }

            } while (tf == true);





        }
        static void Main(string[] args)
        {
            Start();


            int Behavior = 0;
            do
            {

                SelectBehavior();

                Behavior = int.Parse(Console.ReadLine());

                switch (Behavior)
                {
                    case 1:
                        Tutorial();
                        Behavior = 0;
                        break;

                    case 2:
                        MonsterHuntStart();
                        MonsterHuntBattle1();
                        MonsterHuntBattle2();
                        MonsterHuntBattle3();
                        MonsterHuntBattleEnd();
                        Behavior = 0;
                        break;

                    case 3:
                        ManHuntStart();
                        ManHuntBattle1();
                        ManHuntBattle2();
                        ManHuntBattle3();
                        ManHuntBattleEnd();
                        Behavior = 0;
                        break;

                    case 4:
                        Inventory();
                        Behavior = 0;
                        break;
                    case 5:
                        Logout();
                        Console.WriteLine(" 안전한 세계로 돌아갑니다..");
                        Behavior = 1;
                        break;
                    default:
                        Console.WriteLine("선택지를 다시 입력해주세요");
                        Behavior = 0;
                        break;
                }
            } while (Behavior == 0);
        }
    }
}
