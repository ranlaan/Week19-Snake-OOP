using System;
using System.Collections.Generic;
using System.Text;

namespace SankeOOP
{
    class Figure
    {
        protected List<Point> pointList;

        public void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
