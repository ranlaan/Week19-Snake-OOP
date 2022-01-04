﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SankeOOP
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pointList = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            tail.Clear();

            Point head = GetNextPoint();
            pointList.Add(head);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKeys(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }else if(key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }else if(key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }else if(key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }

        }

    }
}
