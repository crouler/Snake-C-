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
    }
}
