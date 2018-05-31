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

        //public virtual char[,] form;
        public virtual char[,] TheBlock  { get; set; }

        public void ShapMove(char[,] form)
        {

        }

        public void ShapTurn(char[,] form) { }

        public void NextShap() { }

        public void DestroyRaw() { }

        public void DelayAction()
        {
            //Timer timer = new Timer();
            //timer.BeginInit();


        }
    }
}
