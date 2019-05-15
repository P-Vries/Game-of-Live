using System;

namespace GameOfLife
{
    class Program
    { 
        static void Main(string[] args)
        {
            var grid = new Write();
            grid.makeGrid();
            

            while (true)
            {
                grid.checkPos();
                grid.writeGrid();
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }


        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            

        }
    }
}
