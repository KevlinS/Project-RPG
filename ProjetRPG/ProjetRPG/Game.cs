using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Game 
    {
        static Player p = new Player(100);

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
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You are in an old building - 1st Floor");
                    Console.WriteLine("LOCATION : Berlin");
                    Console.WriteLine("Info : There are five zombies on this floor");
                    Console.WriteLine("Mission : You have to kill them all and then go up to the second floor");
                    Menu.ButtonCountinue();
                    FirstFloorMission();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }


        }

        public static void PrintStatusPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("YOUR HP:" + p.HealthPoint);
        }

        public void Deplacement()
        {
            //PrintChoix();
            int choix = Menu.AskChoice(0, 4);
            //TODO Récuperer la case
            //TODO Tester le contenu de la case
            //TODO peut etre lancer un combat
        }

        public static void FirstFloorMission()
        {
            PrintStatusPlayer();
            Console.ForegroundColor = ConsoleColor.Red;
            p.GetDamage();
            while (true)
            {
                Menu.ButtonCountinue();
                PrintStatusPlayer();
                Monster.Zombie1GetDamage();
                if(Monster.HPzombie1 <= 0 )
                {
                    Console.WriteLine("YOU KILLED A ZOMBIE");
                    break;
                }
                else if(p.HealthPoint <= 0)
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
    }
}
