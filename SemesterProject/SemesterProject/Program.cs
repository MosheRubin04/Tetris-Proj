using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMenger menger = new GameMenger();
            Screen gameScreen = new Screen();
            gameScreen.DrawBord(gameScreen.screenBoard);
            Square squre1 = new Square();

            VerticalLine vertical = new VerticalLine();

            gameScreen.TurnStart(vertical);
            while (!menger.isGameOver)
            {
                gameScreen.ShapMove(vertical);
            }
        }
    }
}
 