using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            Walls walls = new Walls(120, 30);
            Console.ForegroundColor = ConsoleColor.Red;

            walls.Draw();

            //The points are drawn
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            Console.ForegroundColor = ConsoleColor.Yellow;

            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(120, 30, '$');
            Point food = foodCreator.CreateFood();

            food.Draw();

            Console.ForegroundColor = ConsoleColor.Yellow;


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();

                    Console.ForegroundColor = ConsoleColor.Green;

                    food.Draw();

                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
            }
        }
    }
}