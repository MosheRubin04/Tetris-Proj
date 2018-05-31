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
            Squre squre1 = new Squre();

            gameScreen.Turn(squre1);           
        }
    }
}
 