using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SemesterProject
{
    class GameMenger
    {
        LinkedList<Shape> ShapBank;
        public bool isGameOver { get; set; }
        public string playerName { get; set; }

        Screen gameScreen = new Screen();
        Square squre1 = new Square();
        VerticalLine vertical = new VerticalLine();

        public void Turn()
        {
            gameScreen.DrawBord(gameScreen.screenBoard);
            gameScreen.TurnStart(vertical);
            
            while (!isGameOver)
            {
                Timer timer = new Timer(gameScreen.CallBack, null, 0, 1000);
                gameScreen.ShapMove(vertical);
            }
        }
    }    
}
