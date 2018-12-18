using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    
    class Monster
    {
        public static int HPzombie1;
        static Random rnd = new Random();

        public Monster()
        {

        }

        public static int Zombie1()
        {
            HPzombie1 = 500;
            int damageZombie1 = rnd.Next(25);
            Console.WriteLine("");
            Console.WriteLine("ONE OF THE FIVE ZOMBIE IS COMING AND WANT TO EAT YOU");
            Console.WriteLine("A zombie hits you, BLOOD -" + damageZombie1 + " !");
            Console.WriteLine("");
            return damageZombie1;
        }

        public static int Zombie1GetDamage()
        {

            int degats;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombie1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon : ");
            Console.WriteLine("1.Handgun");
            Console.WriteLine("2.MP5");
            Console.WriteLine("Please enter your choice : ");
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                degats = Inventory.Handgun();
                HPzombie1 -= degats;
                if (HPzombie1 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");
            }
            else if (MyNumber == 2)
            {
                degats = Inventory.MP5();
                HPzombie1 -= degats;
                if (HPzombie1 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");
            }

            else
            {
                Console.WriteLine("You didn't pick the weapon");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HP ZOMBIE : " + HPzombie1);
            return HPzombie1;
        }

    }

    
}
