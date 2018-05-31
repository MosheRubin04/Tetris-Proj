using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Timers;


namespace SemesterProject
{
    class Shape
    {
        GameMenger gameMenger = new GameMenger();
        public void ShapeMove(char[,] form)
        {
            
        }

        public void ShapeTurn(char[,] form) { }

        public void NextShape() { }

        public void DestroyRaw() { }

        public void DelayAction()
        {
            Timer timer = new Timer();
            timer.BeginInit();
            

        }
    }
}
