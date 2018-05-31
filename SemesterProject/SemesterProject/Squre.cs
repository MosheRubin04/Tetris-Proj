using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProject
{
    class Squre : Shape
    {
        //public override char[,] TheBlock = new char[,] { { '#', '#' }, { '#', '#' } };
        char[,] theBlock = new char[,] { { '#', '#' }, { '#', '#' } };

        public override char[,] TheBlock
        {
            get
            {
                return theBlock;
            }
        }
    }
}
