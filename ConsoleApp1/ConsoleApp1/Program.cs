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

            //Point p1 = new Point(1, 3,'*') ;
            //p1.Draw();

            //Point p2 = new Point(4,5,'#');
            //p2.Draw();

            //Point p3 = new Point(8, 2, '&');

            //Point p4 = new Point(5, 3, '$');

            //List<Point> plist = new List<Point>();

            HorizontalLine line = new HorizontalLine(2, 10, 5, '0');
            line.DrawHorline();

            VerticalLine Vline = new VerticalLine(5, 10, 2, '1');
            Vline.DrawVertLine();




          

            Console.ReadLine();



            

        }
    }
}
