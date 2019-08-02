using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 28);
            Console.SetBufferSize(Convert.ToInt16(80), Convert.ToInt16(28));

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(8, 5, '*');

           Snake snake = new Snake(p, 5, Direction.RIGHT);
           snake.Drawline();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true) {
                if (walls.IsHit(snake) || snake.IsHitTail()) {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else {
                    snake.move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);

                }
                
                //snake.move();
            }






            // Console.SetCursorPosition(0, 0);
            Console.ReadLine();



            

        }
    }
}
