using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerticalLine
    {
        List<Point> vLine;
        public VerticalLine(int yTop, int yDown, int x, char sym) {
            vLine = new List<Point>();
            for (int y = yTop; y <= yDown; y++) {
                Point p = new Point(x, y, sym);
                vLine.Add(p);
            }
        }

        public void DrawVertLine() {
            foreach (Point p in vLine) {
                p.Draw();
            }
        }
    }
}
