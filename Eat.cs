public class _EatFood : ISnakeState
{
    //ТЕСТ НА конфликт 2
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
        snake.State = new _LookFood();
    } 
}