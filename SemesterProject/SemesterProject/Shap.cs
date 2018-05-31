using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Timers;


namespace SemesterProject
{
    class Shap
    {
        GameMenger gameMenger = new GameMenger();
        public void ShapMove(char[,] form)
        {
            
        }

        public void ShapTurn(char[,] form) { }

        public void NextShap() { }

        public void DestroyRaw() { }

        public void DelayAction()
        {
            Timer timer = new Timer();
            timer.BeginInit();
            

        }
    }
}
