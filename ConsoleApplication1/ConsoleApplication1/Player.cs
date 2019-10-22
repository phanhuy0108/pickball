using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private String Name;

        public void Pickball(Board game)
        {
            Console.Write("Which Group Do You Want To Pick: ");
            int Group = int.Parse(Console.ReadLine());
            Console.Write("How Many Balls Do you want to pick: ");
            int Balls = int.Parse(Console.ReadLine());
            game.Pickball(Group, Balls);
        }
        public Player(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
