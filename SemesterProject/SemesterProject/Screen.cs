using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using System.Timers;

namespace SemesterProject
{  
    class Screen
    {

        private int startingPointColumns = 20;
        private int startingPointRow = 1;
        private int currnetPosColumns;
        private int currnetPosRow;
        


        static int boardColumns = 40;
        static int boardRows = 50;
        public char[,] screenBoard = new char[boardColumns, boardRows];

        public void GetBordSize()
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Chose bord size");
            
        }

        public void DrawBord(char[,] bord)
        {
            for (int i = 0; i < bord.GetLength(0); i++)
            {                
                for (int j = 0; j < bord.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i+5, j+5);
                    if(i == 0 || j == 0 || i == boardColumns-1 || j == boardRows-1)
                    {
                        Console.Write("@");
                    }

                    else
                    {
                        Console.Write(bord[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }           
        }

        public void Menu() { }

        public void TurnStart(Shape shape)
        {
            currnetPosColumns = startingPointColumns;
            currnetPosRow = startingPointRow;
            Console.Clear();
            for (int i = 0; i < shape.TheBlock.GetLength(0); i++)
            {
                for (int j = 0; j < shape.TheBlock.GetLength(1); j++)
                {
                    screenBoard[currnetPosColumns, currnetPosRow] = shape.TheBlock[i, j];
                    currnetPosColumns++;
                }
                currnetPosColumns = startingPointColumns;
                currnetPosRow++;
            }
            currnetPosRow = startingPointRow;
            
            DrawBord(screenBoard);
        }
        /*
        public void ShapMove(Shape shape)
        {
            Timer timer = new Timer(CallBack, null,0,1000);
        }
        
        public void CallBack(object o)
        {
            if(screenBoard[currnetPosColumns ])
            {
                currnetPosColumns++;
            }
            DrawBord();
        }*/
    }
}
