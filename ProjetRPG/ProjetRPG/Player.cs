using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Player
    {
        public string Name;
        public string Description;
        public int HealthPoint;
        //public int Money;
        public Inventory[] Inven;



        public Player(int hp)
        {
            HealthPoint = hp;
            //Money = money;
        }

        public static string GetNamePlayer()
        {
           
            Console.Write("Enter a name - ");
            return Console.ReadLine();

        }

        public int GetDamage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int degats;
            degats = Monster.Zombie1();
            HealthPoint -= degats;
            if (HealthPoint <= 0)
                Console.WriteLine("PLAYER DEAD");

            return HealthPoint;
        }


    }
}
