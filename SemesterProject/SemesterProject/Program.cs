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
            Screen gameScreen = new Screen();
            gameScreen.DrawBord(gameScreen.screenBoard);
            Square squre1 = new Square();

            VerticalLine vertical = new VerticalLine();

            gameScreen.TurnStart(squre1);           
        }
    }
}
 