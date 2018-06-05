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

        public Shape currentShape = new Shape();


        static int boardColumns = 40;
        static int boardRows = 50;
        public char[,] screenBoard = new char[boardColumns, boardRows];

        public void SetBoardSize()
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Choose board size");
            
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
        
        public void ShapMove(Shape shape)
        {
            if (screenBoard[currnetPosColumns, currnetPosRow + 1] != '#' || screenBoard[currnetPosColumns, currnetPosRow + 1] != '@')
            {
                currnetPosRow++;
                for (int i = 0; i < shape.TheBlock.GetLength(0); i++)
                {
                    for (int j = 0; j < shape.TheBlock.GetLength(1); j++)
                    {
                        screenBoard[currnetPosColumns, currnetPosRow] = shape.TheBlock[i,j];
                    }
                }
                
            }
            DrawBord(screenBoard);
        }
        
        public void CallBack(object o)
        {
            ShapMove(currentShape);
        }
    }
}
