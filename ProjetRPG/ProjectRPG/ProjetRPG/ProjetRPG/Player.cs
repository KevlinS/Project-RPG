using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Player
    {
        public int HealthPoint;
        public int Money;

        

        public Player(int hp, int money)
        {
            HealthPoint = hp;
            Money = money;
        }

        public static string GetNamePlayer()
        {
           
            Console.Write("Enter a name - ");
            return Console.ReadLine();

        }

        public int GetDamageFromZ1_Z2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int degats;
            degats = Monster.Zombie1();
            HealthPoint -= degats;
            if (HealthPoint <= 0)
                Console.WriteLine("PLAYER DEAD");

            return HealthPoint;
        }

        public int GetDamageFromZ3_Z4_Z5()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int degats;
            degats = Monster.Zombie3();
            HealthPoint -= degats;
            if (HealthPoint <= 0)
                Console.WriteLine("PLAYER DEAD");

            return HealthPoint;
        }

        public int GetDamageFromBoss()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int degats;
            degats = Monster.ZombieBoss();
            HealthPoint -= degats;
            if (HealthPoint <= 0)
                Console.WriteLine("PLAYER DEAD");

            return HealthPoint;
        }


    }
}
