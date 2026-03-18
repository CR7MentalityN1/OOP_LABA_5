// Класс FuelTank (Топливный бак)
public class FuelTank
{
    public string TankId { get; set; }
    private double CurrentFuel;

    public FuelTank(string tankId)
    {
        this.TankId = tankId;
        this.CurrentFuel = 0;
    }

    public void Refuel(double amount)
    {
        this.CurrentFuel += amount;
        Console.WriteLine($"Бак {this.TankId} заправлен на {amount} л. Текущий уровень: {this.CurrentFuel} л.");
    }

    public void Consume(double amount)
    {
        if (this.CurrentFuel >= amount)
        {
            this.CurrentFuel -= amount;
            Console.WriteLine($"Из бака {this.TankId} потрачено {amount} л. Остаток: {this.CurrentFuel} л.");
        }
        else
        {
            Console.WriteLine($"Недостаточно топлива в баке {this.TankId}!");
        }
    }

    public void ShowLevel()
    {
        Console.WriteLine($"В баке {this.TankId} осталось {this.CurrentFuel} л.");
    }
}
