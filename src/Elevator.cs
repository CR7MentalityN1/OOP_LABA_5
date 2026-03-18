// Класс Elevator (Лифт)
public class Elevator
{
    public string Model { get; set; }
    public int CurrentFloor { get; set; }
    public int MaxFloor { get; set; }

    public Elevator(string model, int maxFloor)
    {
        this.Model = model;
        this.MaxFloor = maxFloor;
        this.CurrentFloor = 1;
    }

    public void MoveUp(int floors)
    {
        this.CurrentFloor += floors;
        if (this.CurrentFloor > this.MaxFloor)
            this.CurrentFloor = this.MaxFloor;
        Console.WriteLine($"Лифт {this.Model} поднялся на этаж {this.CurrentFloor}");
    }

    public void Reset()
    {
        this.CurrentFloor = 1;
        Console.WriteLine($"Лифт {this.Model} вернулся на 1 этаж");
    }
}
