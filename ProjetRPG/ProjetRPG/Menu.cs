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
            PrintMenu();
            int choix = AskChoice(0, 3);
            switch(choix)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Load();
                    break;
                case 2:
                    APropos();
                    break;
                case 3:
                    Quit();
                    break;

            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("HELLO TOUT LE MONDE");
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

        public void StartGame()
        {
            Console.WriteLine("StartGame");
        }

        public void Load()
        {
            Console.WriteLine("Load");

        }

        public void APropos()
        {
            Console.WriteLine("APropos");

        }

        public void Quit()
        {
            Console.WriteLine("Quit");

        }
    }
}
