using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Snake snake = new Snake(new _LookFood());
        Console.WriteLine("Cостояние змеи = " + snake.State);
        snake.LookFood();
        Console.WriteLine("Cостояние змеи = " + snake.State);
        snake.MoveFood();
        Console.WriteLine("Cостояние змеи = " + snake.State);
        snake.EatFood();
        Console.WriteLine("Cостояние змеи = " + snake.State);
    }
}