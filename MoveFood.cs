public class _MoveFood : ISnakeState
{
    public void LookFood(Snake snake)
    {
        Console.WriteLine("Змея в поисках еды");
        
    } 
    public void MoveFood(Snake snake)
    {
        Console.WriteLine("Змея нашла еду");
        snake.State = new _EatFood();
    } 
    public void EatFood(Snake snake)
    {
        Console.WriteLine("Змея кушает");
    } 
}