using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Snake : Figure
    {
        public Snake(Point tale, int length, Direction direction) {

            plist = new List<Point>();
            for (int i = 0; i < length; i++) {
                Point p = new Point(tale);
                p.Move(i, direction);
                plist.Add(p);
            }

            
        }
    }
}
