using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Game
    {
        public Player player;
        public Map plateau;

        public Game()
        {
            //TODO Faire le constructeur
        }

        public void StartGame()
        {
            //TODO Faire le début du jeu
        }

        public void Deplacement()
        {
            //PrintChoix();
            int choix = Menu.AskChoice(0, 4);
            //TODO Récuperer la case
            //TODO Tester le contenu de la case
            //TODO peut etre lancer un combat
        }
    }
}
