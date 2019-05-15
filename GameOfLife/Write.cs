using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    public class Write : make
    {
        //public make grid = new make();


        public void writeGrid()
        {
            Random alive = new Random();

             for (int x = 0; x < make.gridLength -1; x++)
             {
                for (int y = 0; y < make.gridLength -1; y++)
                {
                    Console.Write(grid[x, y]);
                }
                    Console.Write("\n");
             }  
        }
    }
}
