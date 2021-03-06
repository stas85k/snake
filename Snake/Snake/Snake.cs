﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tall = pList.First();
            pList.Remove(tall);
            Point head = GetNextPoint();
            pList.Add(head);

            tall.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandlKey(ConsoleKey key)
        {
             if (key == ConsoleKey.LeftArrow)
                        direction = Direction.LEFT;
                    else if (key == ConsoleKey.RightArrow)
                        direction = Direction.RIGHT;
                    else if (key == ConsoleKey.DownArrow)
                        direction = Direction.DOWN;
                    else if (key == ConsoleKey.UpArrow)
                        direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            //if(head.x == food.x && head.y == food.y)
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}  
