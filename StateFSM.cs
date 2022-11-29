using System;
using System.Collections;

public class Snake
{
    public ISnakeState State { get; set; }
    public Snake(ISnakeState ss)
    {
        State = ss;
    }
    public void LookFood()
    {
        State.LookFood(this);
    }
    public void MoveFood()
    {
        State.MoveFood(this);
    }
    public void EatFood()
    {
        State.EatFood(this);
    }
}
public interface ISnakeState
{
    void LookFood(Snake snake);
    void MoveFood(Snake snake);
    void EatFood(Snake snake);
}
