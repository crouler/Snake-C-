using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int ofset, Direction dir)
        {
           switch (dir) {
                case Direction.RIGHT:
                    x = x + ofset;
                    break;
                case Direction.LEFT:
                    x = x - ofset;
                    break;
                case Direction.UP:
                    y = y - ofset;
                    break;
                case Direction.DOWN:
                    y = y + ofset;
                    break;

            /*if (dir == Direction.RIGHT) {
                x = x + ofset;
            }

            else if (dir == Direction.LEFT) { 
                x = x - ofset;
            }

            else if (dir == Direction.UP){
                y = y - ofset;
            }
            else if (dir == Direction.DOWN){
                y = y + ofset;*/
            }
        }



        public void Draw() {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void Clear() {
            sym = ' ';
            Draw();
        }


        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

    }
}
