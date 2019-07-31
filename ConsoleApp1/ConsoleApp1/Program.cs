using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 28);
           // Console.SetCursorPosition(10, 4);
            //Console.WriteLine("Height = " + Console.BufferHeight.ToString() + ",  Width = " + Console.BufferWidth.ToString());
            
            Console.SetBufferSize(Convert.ToInt16(80), Convert.ToInt16(28));
           // Console.SetCursorPosition(10,5);
           // Console.WriteLine("Height = " + Console.BufferHeight.ToString() + ",  Width = " + Console.BufferWidth.ToString());


            HorizontalLine upline = new HorizontalLine(0, 79, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 79, 25, '+');
             upline.Drawline();
             downline.Drawline();

           VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
           VerticalLine rightline = new VerticalLine(0, 24, 79, '+');
           leftline.Drawline();
           rightline.Drawline();

            Point p = new Point(8,5,'*');

           Snake snake = new Snake(p, 3, Direction.RIGHT);
           snake.Drawline();
           


           // Console.SetCursorPosition(0, 0);
            Console.ReadLine();



            

        }
    }
}
