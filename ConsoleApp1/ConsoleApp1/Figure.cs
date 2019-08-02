using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Figure
    {
        protected List<Point> plist;
        
        public void Drawline()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }

        internal bool isHit(Figure figure)
        {
            foreach (var p in plist)
            {
                if (figure.isHit(p))
                    return true;
                 
            }
            return false;
            //throw new NotImplementedException();
        }

        private bool isHit(Point point)
        {
            foreach (var p in plist)
            {
                if (p.IsHit(point))
                    return true;
                
            }
            return false;
        }
    }
}
