using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Snake : Figure

    {
        Direction dir;
        public Snake(Point tale, int length, Direction _direction) {

            dir = _direction;

            plist = new List<Point>();
            for (int i = 0; i < length; i++) {
                Point p = new Point(tale);
                p.Move(i, dir);
                plist.Add(p);
            }

            
        }

        internal void move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();

            //throw new NotImplementedException();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, dir);
            return nextpoint;

            throw new NotImplementedException();
        }
    }
}
