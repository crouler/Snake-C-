using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight) {

            wallList = new List<Figure>();

            HorizontalLine upline = new HorizontalLine(0, mapWidth - 1, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, mapWidth - 1, mapHeight, '+');

            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapWidth - 1, '+');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList) {
                if (wall.isHit(figure))
                {
                    return true;
                }
                
            }
            return false;
            //throw new NotImplementedException();
        }


        public void Draw() {
            foreach (Figure wall in  wallList) {
                wall.Drawline();
            }
        }


    }
}
