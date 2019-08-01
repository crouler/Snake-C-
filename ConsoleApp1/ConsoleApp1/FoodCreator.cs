using System;

namespace ConsoleApp1
{
    internal class FoodCreator
    {
        private int width;
        private int height;
        private char sym;

        Random random = new Random();
        public FoodCreator(int width, int height, char sym)
        {
            this.width = width;
            this.height = height;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, width - 2);
            int y = random.Next(2, height - 2);
            return new Point(x, y, sym);

            throw new NotImplementedException();
        }
    }
}