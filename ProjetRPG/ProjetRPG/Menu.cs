using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Menu
    {

        public Menu()
        {
            
        }

        public static void PrintWelcomeText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ________                     __                      __  __              __      __        ____               __                             __                          
/\_____  \                   /\ \      __            /\ \/\ \  __        /\ \    /\ \__    /\  _`\            /\ \                           /\ \__  __                   
\/____//'/'    ___    ___ ___\ \ \____/\_\     __    \ \ `\\ \/\_\     __\ \ \___\ \ ,_\   \ \ \L\ \     __   \_\ \     __    ___ ___   _____\ \ ,_\/\_\    ___    ___    
     //'/'    / __`\/' __` __`\ \ '__`\/\ \  /'__`\   \ \ , ` \/\ \  /'_ `\ \  _ `\ \ \/    \ \ ,  /   /'__`\ /'_` \  /'__`\/' __` __`\/\ '__`\ \ \/\/\ \  / __`\/' _ `\  
    //'/'___ /\ \L\ \\ \/\ \/\ \ \ \L\ \ \ \/\  __/    \ \ \`\ \ \ \/\ \L\ \ \ \ \ \ \ \_    \ \ \\ \ /\  __//\ \L\ \/\  __//\ \/\ \/\ \ \ \L\ \ \ \_\ \ \/\ \L\ \\ \/\ \ 
    /\_______\ \____/ \_\ \_\ \_\ \_,__/\ \_\ \____\    \ \_\ \_\ \_\ \____ \ \_\ \_\ \__\    \ \_\ \_\ \____\ \___,_\ \____\ \_\ \_\ \_\ \ ,__/\ \__\\ \_\ \____/ \_\ \_\
    \/_______/\/___/ \/_/\/_/\/_/\/___/  \/_/\/____/     \/_/\/_/\/_/\/___L\ \/_/\/_/\/__/     \/_/\/ /\/____/\/__,_ /\/____/\/_/\/_/\/_/\ \ \/  \/__/ \/_/\/___/ \/_/\/_/
                                                                       /\____/                                                            \ \_\                           
                                                                       \_/__/                                                              \/_/                           
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                      
                      .....                                                  
                     C C  /                                                  
                    /<   /     MILTON FRIEDMAN HAS COME BACK FROM THE DEAD   
     ___ __________/_#__=o     TO SHARE HIS VIEWS ON FREEDOM, MONETARY       
    /(- /(\_\________   \      POLICY, AND THE PROPER ROLE OF THE FEDERAL    
    \ ) \ )_      \o     \     GOVERNMENT VIS A VIS FEDERALISM AND LIBERTY   
    /|\ /|\       |'     |                                                   
                  |     _|                                                   
                  /o   __\                                                   
                 / '     |     OH AND TO EAT YOUR BRAINS                     
                / /      |                                                   
               /_/\______|                                                   
              (   _(    <                                                    
               \    \    \                                                   
                \    \    |    ACTUALLY IT'S PROBABLY JUST TO EAT YOUR BRAINS
                 \____\____\   FROM THE LOOKS OF HIM                         
                 ____\_\__\_\                                 " + "\n");

            ButtonCountinue();

        }

        public static void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|+|ZOMBIE NIGHT REDEMPTION|+|");
            Console.WriteLine("MAIN MENU :");
            Console.WriteLine("1. Start New Game");
            Console.WriteLine("2. About");
            Console.WriteLine("3. Exit Game");
            Console.WriteLine("Your choice : ");
        }

        public static void ButtonCountinue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press ENTER to continue...");
            Console.WriteLine("");
            ConsoleKeyInfo Button = Console.ReadKey();
            if (Button.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
            }
            else
                Environment.Exit(0);
            
        }

        public static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        public static void ChoiceMenu()
        {
            int choix = AskChoice(1, 3);
            switch (choix)
            {
                case 1:
                    Game.StartNewGame();
                    break;
                case 2:
                    Console.WriteLine(@" ______                _     _        _   _ _       _     _    ______         _                      _   _             
|___  /               | |   (_)      | \ | (_)     | |   | |   | ___ \       | |                    | | (_)            
   / /  ___  _ __ ___ | |__  _  ___  |  \| |_  __ _| |__ | |_  | |_/ /___  __| | ___ _ __ ___  _ __ | |_ _  ___  _ __  
  / /  / _ \| '_ ` _ \| '_ \| |/ _ \ | . ` | |/ _` | '_ \| __| |    // _ \/ _` |/ _ \ '_ ` _ \| '_ \| __| |/ _ \| '_ \ 
./ /__| (_) | | | | | | |_) | |  __/ | |\  | | (_| | | | | |_  | |\ \  __/ (_| |  __/ | | | | | |_) | |_| | (_) | | | |
\_____/\___/|_| |_| |_|_.__/|_|\___| \_| \_/_|\__, |_| |_|\__| \_| \_\___|\__,_|\___|_| |_| |_| .__/ \__|_|\___/|_| |_|
                                               __/ |                                          | |                      
                                              |___/                                           |_|                      
______                                                                                                                 
| ___ \                                                                                                                
| |_/ /_   _                                                                                                           
| ___ \ | | |                                                                                                          
| |_/ / |_| |                                                                                                          
\____/ \__, |                                                                                                          
        __/ |                                                                                                          
       |___/                                                                                                           
  ___  _         _      _ _           _               _   __           _ _                                             
 / _ \| |       | |    | | |         | |      ___    | | / /          | (_)                                            
/ /_\ \ |__   __| | ___| | |__   __ _| | __  ( _ )   | |/ /  _____   _| |_ _ __                                        
|  _  | '_ \ / _` |/ _ \ | '_ \ / _` | |/ /  / _ \/\ |    \ / _ \ \ / / | | '_ \                                       
| | | | |_) | (_| |  __/ | | | | (_| |   <  | (_>  < | |\  \  __/\ V /| | | | | |                                      
\_| |_/_.__/ \__,_|\___|_|_| |_|\__,_|_|\_\  \___/\/ \_| \_/\___| \_/ |_|_|_| |_|                                      
                                                                                    ");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
