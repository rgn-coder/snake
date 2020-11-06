
using System.Collections.Generic;



namespace SnakeGame
{
    class HorizontalLines : Figure

    { 

        public HorizontalLines(int xLeft, int xRight, int y, char sym)

        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


        }
        
    }

}
    

    

