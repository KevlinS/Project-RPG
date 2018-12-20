using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    
    class Monster
    {
        public int HPzombie1;
        public int HPzombie1_2;
        public int HPzombie1_3;
        public int HPzombie1_4;
        public int HPzombie1_5;
        public int HPzombieBoss;
        static Random rnd = new Random();

        public Monster(int hpZ1, int hpZ2, int hpZ3, int hpZ4, int hpZ5, int hpZBOSS)
        {
            HPzombie1 = hpZ1;
            HPzombie1_2 = hpZ2;
            HPzombie1_3 = hpZ3;
            HPzombie1_4 = hpZ4;
            HPzombie1_5 = hpZ5;
            HPzombieBoss = hpZBOSS;
        }

        public static int Zombie1()
        {
            //HPzombie1 = 500;
            int damageZombie1 = rnd.Next(25);
            Console.WriteLine("");
            Console.WriteLine("Zombie hits you, BLOOD -" + damageZombie1 + " !!");
            Console.WriteLine("");
            return damageZombie1;
        }

        public static int Zombie2()
        {
            
            int damageZombie2 = rnd.Next(25);
            Console.WriteLine("");
            Console.WriteLine("Zombie hits you, BLOOD -" + damageZombie2 + " !!");
            Console.WriteLine("");
            return damageZombie2;
        }

        public static int Zombie3()
        {

            int damageZombie3 = rnd.Next(30);
            Console.WriteLine("");
            Console.WriteLine("Zombie hits you, BLOOD -" + damageZombie3 + " !!");
            Console.WriteLine("");
            return damageZombie3;
        }

        public static int Zombie4()
        {

            int damageZombie4 = rnd.Next(30);
            Console.WriteLine("");
            Console.WriteLine("Zombie hits you, BLOOD -" + damageZombie4 + " !!");
            Console.WriteLine("");
            return damageZombie4;
        }

        public static int Zombie5()
        {

            int damageZombie5 = rnd.Next(30);
            Console.WriteLine("");
            Console.WriteLine("Zombie hits you, BLOOD -" + damageZombie5 + " !!");
            Console.WriteLine("");
            return damageZombie5;
        }

        public static int ZombieBoss()
        {

            int damageZombieBoss = rnd.Next(40);
            Console.WriteLine("");
            Console.WriteLine("Zombie hits you, BLOOD -" + damageZombieBoss + " !!");
            Console.WriteLine("");
            return damageZombieBoss;
        }



        public int Zombie1GetDamage()
        {
            
            int degats;
            

            PrintChoiceZombie1GD();
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                Game.BuyHandgun();
                degats = Inventory.Handgun();
                HPzombie1 -= degats;
                if (HPzombie1 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }
            else if (MyNumber == 2)
            {
                Game.BuyMP5();
                degats = Inventory.MP5();
                HPzombie1 -= degats;
                if (HPzombie1 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");
               
            }

            else if (MyNumber == 3)
            {
                Game.BuySniper();
                degats = Inventory.Sniper();
                HPzombie1 -= degats;
                if (HPzombie1 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 4)
            {
                Game.BuyHeal();
                Game.GetHealPlayer();
            }


            else if (MyNumber == 0)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("You didn't choose anything");
            }

            Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("HP ZOMBIE : " + HPzombie1);
            return HPzombie1;
        }

        public int Zombie2GetDamage()
        {

            int degats;

            
            PrintChoiceZombie2GD();
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                Game.BuyHandgun();
                degats = Inventory.Handgun();
                HPzombie1_2 -= degats;
                if (HPzombie1_2 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }
            else if (MyNumber == 2)
            {
                Game.BuyMP5();
                degats = Inventory.MP5();
                HPzombie1_2 -= degats;
                if (HPzombie1_2 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 3)
            {
                Game.BuySniper();
                degats = Inventory.Sniper();
                HPzombie1_2 -= degats;
                if (HPzombie1_2 <= 0)
                    Console.WriteLine("ZOMBIE DEAD ");

            }

            else if (MyNumber == 4)
            {
                Game.BuyHeal();
                Game.GetHealPlayer();
            }


            else if (MyNumber == 0)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("You didn't choose anything");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            
            return HPzombie1_2;
        }

        public int Zombie3GetDamage()
        {

            int degats;


            PrintChoiceZombie3GD();
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                Game.BuyHandgun();
                degats = Inventory.Handgun();
                HPzombie1_3 -= degats;
                if (HPzombie1_3 <= 0)
                    Console.WriteLine("ZOMBIE DEAD ");

            }
            else if (MyNumber == 2)
            {
                Game.BuyMP5();
                degats = Inventory.MP5();
                HPzombie1_3 -= degats;
                if (HPzombie1_3 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 3)
            {
                Game.BuySniper();
                degats = Inventory.Sniper();
                HPzombie1_3 -= degats;
                if (HPzombie1_3 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 4)
            {
                Game.BuyHeal();
                Game.GetHealPlayer();
            }


            else if (MyNumber == 0)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("You didn't choose anything");
            }

            Console.ForegroundColor = ConsoleColor.Red;

            return HPzombie1_3;
        }

        public int Zombie4GetDamage()
        {

            int degats;


            PrintChoiceZombie4GD();
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                Game.BuyHandgun();
                degats = Inventory.Handgun();
                HPzombie1_4 -= degats;
                if (HPzombie1_4 <= 0)
                    Console.WriteLine("ZOMBIE DEAD ");

            }
            else if (MyNumber == 2)
            {
                Game.BuyMP5();
                degats = Inventory.MP5();
                HPzombie1_4 -= degats;
                if (HPzombie1_4 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 3)
            {
                Game.BuySniper();
                degats = Inventory.Sniper();
                HPzombie1_4 -= degats;
                if (HPzombie1_4 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 4)
            {
                Game.BuyHeal();
                Game.GetHealPlayer();
            }


            else if (MyNumber == 0)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("You didn't choose anything");
            }

            Console.ForegroundColor = ConsoleColor.Red;

            return HPzombie1_4;
        }

        public int Zombie5GetDamage()
        {

            int degats;


            PrintChoiceZombie5GD();
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                Game.BuyHandgun();
                degats = Inventory.Handgun();
                HPzombie1_5 -= degats;
                if (HPzombie1_5 <= 0)
                    Console.WriteLine("ZOMBIE DEAD ");

            }
            else if (MyNumber == 2)
            {
                Game.BuyMP5();
                degats = Inventory.MP5();
                HPzombie1_5 -= degats;
                if (HPzombie1_5 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 3)
            {
                Game.BuySniper();
                degats = Inventory.Sniper();
                HPzombie1_5 -= degats;
                if (HPzombie1_5 <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 4)
            {
                Game.BuyHeal();
                Game.GetHealPlayer();
            }


            else if (MyNumber == 0)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("You didn't choose anything");
            }

            Console.ForegroundColor = ConsoleColor.Red;

            return HPzombie1_5;
        }

        public int ZombieBossGetDamage()
        {

            int degats;


            PrintChoiceZombieBossGD();
            int MyNumber = int.Parse(Console.ReadLine());
            if (MyNumber == 1)
            {
                Game.BuyHandgun();
                degats = Inventory.Handgun();
                HPzombieBoss -= degats;
                if (HPzombieBoss <= 0)
                    Console.WriteLine("ZOMBIE DEAD ");

            }
            else if (MyNumber == 2)
            {
                Game.BuyMP5();
                degats = Inventory.MP5();
                HPzombieBoss -= degats;
                if (HPzombieBoss <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 3)
            {
                Game.BuySniper();
                degats = Inventory.Sniper();
                HPzombieBoss -= degats;
                if (HPzombieBoss <= 0)
                    Console.WriteLine("ZOMBIE DEAD");

            }

            else if (MyNumber == 4)
            {
                Game.BuyHeal();
                Game.GetHealPlayer();
            }


            else if (MyNumber == 0)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("You didn't choose anything");
            }

            Console.ForegroundColor = ConsoleColor.Red;

            return HPzombieBoss;
        }





        public void PrintChoiceZombie1GD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombie1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon :");
            Console.WriteLine("1.Handgun - 500 GOLD");
            Console.WriteLine("2.MP5 - 1000 GOLD");
            Console.WriteLine("3.Sniper - 1750 GOLD");
            Console.WriteLine("4.Heal - 1000 GOLD");
            Console.WriteLine("0.Quit Game");
            Console.WriteLine("Please enter your choice : ");
        }

        public void PrintChoiceZombie2GD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombie1_2);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon : ");
            Console.WriteLine("1.Handgun - 500 GOLD");
            Console.WriteLine("2.MP5 - 1000 GOLD");
            Console.WriteLine("3.Sniper - 1750 GOLD");
            Console.WriteLine("4.Heal - 1000 GOLD");
            Console.WriteLine("0.Quit Game");
            Console.WriteLine("Please enter your choice : ");
        }

        public void PrintChoiceZombie3GD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombie1_3);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon : ");
            Console.WriteLine("1.Handgun - 500 GOLD");
            Console.WriteLine("2.MP5 - 1000 GOLD");
            Console.WriteLine("3.Sniper - 1750 GOLD");
            Console.WriteLine("4.Heal - 1000 GOLD");
            Console.WriteLine("0.Quit Game");
            Console.WriteLine("Please enter your choice : ");
        }

        public void PrintChoiceZombie4GD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombie1_4);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon : ");
            Console.WriteLine("1.Handgun - 500 GOLD");
            Console.WriteLine("2.MP5 - 1000 GOLD");
            Console.WriteLine("3.Sniper - 1750 GOLD");
            Console.WriteLine("4.Heal - 1000 GOLD");
            Console.WriteLine("0.Quit Game");
            Console.WriteLine("Please enter your choice : ");
        }

        public void PrintChoiceZombie5GD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombie1_5);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon : ");
            Console.WriteLine("1.Handgun - 500 GOLD");
            Console.WriteLine("2.MP5 - 1000 GOLD");
            Console.WriteLine("3.Sniper - 1750 GOLD");
            Console.WriteLine("4.Heal - 1000 GOLD");
            Console.WriteLine("0.Quit Game");
            Console.WriteLine("Please enter your choice : ");
        }

        public void PrintChoiceZombieBossGD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("HP ZOMBIE : " + HPzombieBoss);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It's your turn");
            Console.WriteLine("Choose your weapon : ");
            Console.WriteLine("1.Handgun - 500 GOLD");
            Console.WriteLine("2.MP5 - 1000 GOLD");
            Console.WriteLine("3.Sniper - 1750 GOLD");
            Console.WriteLine("4.Heal - 1000 GOLD");
            Console.WriteLine("0.Quit Game");
            Console.WriteLine("Please enter your choice :");
        }
    }

    
}
