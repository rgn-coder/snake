using System;
namespace SnakeGame
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public Point()
            
        {
            
        }
    }
}
