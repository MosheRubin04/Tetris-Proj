using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace SemesterProject
{
    class Shape
    {
        public virtual char[,] TheBlock  { get; set; }

        public virtual int BottomPointColumn { get; set; }

        public virtual int BottomPointRow { get; set; }

        public void ShapTurn(char[,] form) { }

        public void NextShap() { }

        public void DestroyRaw() { }
        
    }
}
