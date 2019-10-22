using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Controller
    {
        private Board Game;
        private Player P1,P2;

        public Controller()
        {
            this.Game = new Board(3, 4, 6);
            this.P1 = new Player("Gau Ca");
            this.P2 = new Player("Nhan");
        }

        public void PlayGame()
        {
            Game.PrintGame();
            while(true)
            {
                Console.WriteLine(P1.GetName()+ " Plays ....");
                P1.Pickball(Game);
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName()+" You Lose");
                    break;
                }
                Console.WriteLine(P2.GetName()+ " Plays ....");
                P2.Pickball(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() +" You Lose");
                    break;
                }
            }
                
                
            
        }
    }
}
