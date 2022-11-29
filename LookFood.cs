using System;
using System.Collections;

public class _LookFood : ISnakeState
{
    public void LookFood(Snake snake)
    {
        Console.WriteLine("Змея в поисках еды");
        snake.State = new _MoveFood();
    } 
    public void MoveFood(Snake snake)
    {
        Console.WriteLine("Змея нашла еду");
    } 
    public void EatFood(Snake snake)
    {
        Console.WriteLine("Змея кушает");
    } 
}