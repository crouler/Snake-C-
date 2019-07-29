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
            
            Point p1 = new Point(1, 3,'*') ;
            //p1.Draw();

            Point p2 = new Point(4,5,'#');
            //p2.Draw();

            Point p3 = new Point(8, 2, '&');

            Point p4 = new Point(5, 3, '$');

            List<Point> plist = new List<Point>();

        
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);

            foreach (Point p in plist) {
                p.Draw();
            }

            Console.ReadLine();



            

        }
    }
}
