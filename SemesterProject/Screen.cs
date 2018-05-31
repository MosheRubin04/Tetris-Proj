using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProject
{  
    class Screen
    {

        static int boardX = 40;
        static int boardY = 50;
        public char[,] board1 = new char[boardX, boardY];

        public void GetBoardSize()
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Choose board  size");
            
        }

        public void DrawBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {                
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i+5, j+5);
                    if(i == 0 || j == 0 || i == boardX -1 || j == boardY -1)
                    {
                        Console.Write("#");
                    }
                    
                }
                Console.WriteLine();
            }           
        }

        public void Menu() { }


    }
}
