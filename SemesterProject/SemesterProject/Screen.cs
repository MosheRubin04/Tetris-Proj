using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProject
{  
    class Screen
    {

        static int bordX = 40;
        static int bordY = 50;
        public char[,] bord1 = new char[bordX, bordY];

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
                    if(i == 0 || j == 0 || i == bordX-1 || j == bordY-1)
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
