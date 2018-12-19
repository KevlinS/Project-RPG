using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Inventory
    {

        static Random rnd = new Random();

        public static int Handgun()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("You use a Handgun");
            int damageHandgun = rnd.Next(200,300);
            Console.WriteLine(@",--^----------,--------,-----,-------^--,
 | |||||||||   `--------'     |          O
 `+---------------------------^----------|
   `\_,-------, _________________________|
     / XXXXXX /`|     /
    / XXXXXX /  `\   /
   / XXXXXX /\______(
  / XXXXXX /
 / XXXXXX /
(________(
 `------' ");
            Console.WriteLine("");
            Console.WriteLine("HIT " + damageHandgun);
            if (damageHandgun > 270)
            {
                Console.WriteLine("CRITICAL!");
            }

            return damageHandgun;
        }

        public static int MP5()
        {
         
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("You use a MP5");
            int damageMP5 = rnd.Next(300, 350);
            Console.WriteLine(@"||
  ||_________________________/'|
 _| O======/                   |
|_|              ============  |
  |  __  ______________________|
  |_/  )(     |___||     O-   /
      (  )    /  / |_________/
      (  )   /  /    | ) |   |
      (__)  /  /     \___|__(
           /  /          )   \
          /  /            )   \
         /  /              )___\
        /  /
       /__/
");
            Console.WriteLine("");
            Console.WriteLine("HIT " + damageMP5);
            if (damageMP5 > 330)
            {
                Console.WriteLine("CRITICAL!");
            }

            return damageMP5;
        }

        public static int Sniper()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("You use a Sniper");
            int damageSniper = 750;
            Console.WriteLine(@"             _________                      _
 __------____/    ===  ========================
 |               ________________/
 |      ___--_/(_)             ^
 |___---");
            Console.WriteLine("");
            Console.WriteLine("HIT " + damageSniper);
            
            return damageSniper;
        }

        public static int Heal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("You use a Heal");
            int soin = 100;
            Console.WriteLine(@"   `.___,'
      (___)
      <   >
       ) (
      /`-.\
     /     \
    / _    _\
   :,' `-.' `:
   |         |
   :         ;
    \       /
     `.___.' ");
            Console.WriteLine("");
            Console.WriteLine("Heal " + soin);
            return soin;
        }
    }
    
}
