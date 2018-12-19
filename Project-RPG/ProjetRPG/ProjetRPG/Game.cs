using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Game 
    {
        static Player p = new Player(100, 5000);
        static Monster m = new Monster(500, 500, 550, 550, 550, 2500);

        public Game()
        {
            

        }

        public static void StartNewGame()
        {
            string namePlayer = Player.GetNamePlayer();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hello " + namePlayer + "!!!");
            Console.WriteLine(@"ARMIES OF MINDLESS ZOMBIES ARE TAKING OVER THE WORLD! 
It's up to you to help stop them in our huge collection of 
great zombie games! Whether you want to resist the undead hordes or join them, 
you'll have more than enough choice 
to get your fill of zombie fighting action." + "\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1.Continue");
            Console.WriteLine("2.Quit");
            Console.WriteLine("Your choice : ");


            int choix = Menu.AskChoice(1, 2);
            switch (choix)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("===== BE CAREFUL WHEN USING YOUR GOLD. IF YOU C'ANT BUY ANYTHING, YOU C'ANT SURVIVE =====");
                    PrintStatusZombie1();
                    PrintStatusPlayer();
                    PrintZombie1Coming();
                    FirstFloorMissionCombat();
                    PrintZombie2Coming();
                    FirstFloorMissionCombat1_2();
                    PrintZombie3Coming();
                    FirstFloorMissionCombat1_3();
                    PrintZombie4Coming();
                    FirstFloorMissionCombat1_4();
                    PrintZombie5Coming();
                    FirstFloorMissionCombat1_5();
                    PrintZombieBossComing();
                    FirstFloorMissionCombatBoss();



                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }


        }
        public static int BuyHandgun()
        {
            return p.Money -= 500;
        }

        public static int BuyMP5()
        {
            return p.Money -= 1000;
        }

        public static int BuyHeal()
        {
            return p.Money -= 1000;
        }

        public static int BuySniper()
        {
            return p.Money -= 1750;
        }


        public static int GetHealPlayer()
        {
            int AddHeal;
            Console.ForegroundColor = ConsoleColor.Green;
            
            AddHeal = Inventory.Heal();
            p.HealthPoint += AddHeal;

            if(p.HealthPoint > 100)
            {
                p.HealthPoint = 100;
            }

            return p.HealthPoint;

        }

        public static void PrintZombie1Coming()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FIRST ZOMBIE IS COMING AND WANT TO EAT YOU!!!");
        }

        public static void PrintZombie2Coming()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("SECOND ZOMBIE IS COMING AND WANT TO EAT YOU!!!");
        }

        public static void PrintZombie3Coming()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("THIRD ZOMBIE IS COMING AND WANT TO EAT YOU!!!");
        }

        public static void PrintZombie4Coming()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("FOURTH ZOMBIE IS COMING AND WANT TO EAT YOU!!!");
        }

        public static void PrintZombie5Coming()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("FIFTH ZOMBIE IS COMING AND WANT TO EAT YOU!!!");
        }

        public static void PrintZombieBossComing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("===== ZOMBIE BOSS IS COMING!!! =====");
        }

        public static void PrintStatusPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (p.HealthPoint <= 0 || p.Money < 500)
            {

                p.HealthPoint = 100;
                p.Money = 5000;
                Console.WriteLine("YOU CAN'T SURVIVE, GAME OVER!!!");
                Menu.PrintWelcomeText();
                Menu.PrintMenu();
                Menu.ChoiceMenu();

            }
            else
            {
                Console.WriteLine("YOUR HP:" + p.HealthPoint + " YOUR GOLD:" + p.Money);
            }
            
        }

        public static void PrintStatusZombie1()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if(m.HPzombie1 <= 0)
            {
                p.Money += 2000;
                Console.WriteLine("FIRST ZOMBIE HAS GONE");
                Console.WriteLine("YOU RECEIVE 2000 GOLD");
            }
            else
            {
                Console.WriteLine("HP ZOMBIE:" + m.HPzombie1);
            }
        }

        public static void PrintStatusZombie1_2()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (m.HPzombie1_2 <= 0)
            {
                p.Money += 2000;
                Console.WriteLine("SECOND ZOMBIE HAS GONE");
                Console.WriteLine("YOU RECEIVE 2000 GOLD");
            }
            else
            {
                Console.WriteLine("HP ZOMBIE:" + m.HPzombie1_2);
            }
        }

        public static void PrintStatusZombie1_3()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (m.HPzombie1_3 <= 0)
            {
                p.Money += 2000;
                Console.WriteLine("THIRD ZOMBIE HAS GONE");
            }
            else
            {
                Console.WriteLine("HP ZOMBIE:" + m.HPzombie1_3);
            }
        }

        public static void PrintStatusZombie1_4()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (m.HPzombie1_4 <= 0)
            {
                p.Money += 2000;
                Console.WriteLine("FOURTH ZOMBIE HAS GONE");
            }
            else
            {
                Console.WriteLine("HP ZOMBIE:" + m.HPzombie1_4);
            }
        }

        public static void PrintStatusZombie1_5()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (m.HPzombie1_5 <= 0)
            {
                p.Money += 2000;
                Console.WriteLine("FIFTH ZOMBIE HAS GONE");
            }
            else
            {
                Console.WriteLine("HP ZOMBIE:" + m.HPzombie1_5);
            }
        }

        public static void PrintStatusZombieBoss()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (m.HPzombie1_5 <= 0)
            {
                p.Money += 10000;
                Console.WriteLine("===== ALL ZOMBIES DEAD =====");
                Console.WriteLine("===== MISSION SUCCESS - STAGE 1 COMPLETED =====");
            }
            else
            {
                Console.WriteLine("HP ZOMBIE:" + m.HPzombie1_5);
            }
        }

        public static void FirstFloorMissionCombat()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You are in an old building - 1st Floor");
            Console.WriteLine("LOCATION : Berlin");
            Console.WriteLine("Info : There are five zombies on this floor");
            Console.WriteLine("Mission : You have to kill them all and then go up to the second floor");
            Console.WriteLine();
            Console.WriteLine("START COMBAT!!!");
            Menu.ButtonCountinue();
            

            while (true)
            {

                PrintStatusPlayer();
                Menu.ButtonCountinue();
                p.GetDamage();
                PrintStatusPlayer();
                m.Zombie1GetDamage();
                PrintStatusZombie1();

                if (m.HPzombie1 <= 0)
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE");
                    break;
                }
                else if (p.HealthPoint <= 0)
                {
                    Console.WriteLine("ZOMBIE KILLED YOU");
                    break;
                }
                else
                {
                    continue;
                }

            }

        }

        public static void FirstFloorMissionCombat1_2()
        {
           
            while (true)
            {

                PrintStatusPlayer();
                Menu.ButtonCountinue();
                p.GetDamage();
                PrintStatusPlayer();
                m.Zombie2GetDamage();
                PrintStatusZombie1_2();

                if (m.HPzombie1_2 <= 0)
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE");
                    break;
                }
                else if (p.HealthPoint <= 0)
                {
                    Console.WriteLine("ZOMBIE KILLED YOU");
                    break;
                }
                else
                {
                    continue;
                }



            }


        }

        public static void FirstFloorMissionCombat1_3()
        {

            while (true)
            {

                PrintStatusPlayer();
                Menu.ButtonCountinue();
                p.GetDamage();
                PrintStatusPlayer();
                m.Zombie3GetDamage();
                PrintStatusZombie1_3();

                if (m.HPzombie1_3 <= 0)
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE");
                    break;
                }
                else if (p.HealthPoint <= 0)
                {
                    Console.WriteLine("ZOMBIE KILLED YOU");
                    break;
                }
                else
                {
                    continue;
                }



            }


        }

        public static void FirstFloorMissionCombat1_4()
        {

            while (true)
            {

                PrintStatusPlayer();
                Menu.ButtonCountinue();
                p.GetDamage();
                PrintStatusPlayer();
                m.Zombie4GetDamage();
                PrintStatusZombie1_4();

                if (m.HPzombie1_4 <= 0)
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE");
                    break;
                }
                else if (p.HealthPoint <= 0)
                {
                    Console.WriteLine("ZOMBIE KILLED YOU");
                    break;
                }
                else
                {
                    continue;
                }



            }


        }

        public static void FirstFloorMissionCombat1_5()
        {

            while (true)
            {

                PrintStatusPlayer();
                Menu.ButtonCountinue();
                p.GetDamage();
                PrintStatusPlayer();
                m.Zombie5GetDamage();
                PrintStatusZombie1_5();

                if (m.HPzombie1_5 <= 0)
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE");
                    break;
                }
                else if (p.HealthPoint <= 0)
                {
                    Console.WriteLine("ZOMBIE KILLED YOU");
                    break;
                }
                else
                {
                    continue;
                }



            }


        }

        public static void FirstFloorMissionCombatBoss()
        {

            while (true)
            {

                PrintStatusPlayer();
                Menu.ButtonCountinue();
                p.GetDamage();
                PrintStatusPlayer();
                m.ZombieBossGetDamage();
                PrintStatusZombieBoss();

                if (m.HPzombieBoss <= 0)
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE BOSS");
                    break;
                }
                else if (p.HealthPoint <= 0)
                {
                    Console.WriteLine("ZOMBIE BOSS KILLED YOU");
                    break;
                }
                else
                {
                    continue;
                }



            }


        }
    }
}
