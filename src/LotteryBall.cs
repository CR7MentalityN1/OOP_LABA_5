// Класс LotteryBall (Лототрон)
using System;

public class LotteryBall
{
    private int _maxNumber;
    private Random _random;

    public LotteryBall(int maxNumber = 60)
    {
        _maxNumber = maxNumber;
        _random = new Random();
    }

    public int Draw()
    {
        return _random.Next(1, _maxNumber + 1);
    }
}
