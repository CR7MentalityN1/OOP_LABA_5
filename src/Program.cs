// Точка входа для лабораторной работы №5
using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1: Класс Product
        Product product1 = new Product();
        Product product2 = new Product("Ноутбук", 59999.99m, true);

        Console.WriteLine("Первый товар:");
        product1.ShowInfo();
        Console.WriteLine("Второй товар:");
        product2.ShowInfo();

        // Задание 2: Класс FuelTank
        FuelTank tank = new FuelTank("A1");
        tank.Refuel(50);
        tank.Consume(20);
        tank.ShowLevel();

        // Задание 3: Класс Elevator
        Elevator elevator = new Elevator("Otis", 15);
        elevator.MoveUp(10);
        elevator.Reset();

        // Задание 4: Класс LotteryBall
        LotteryBall lotto60 = new LotteryBall(60);
        LotteryBall lotto100 = new LotteryBall(100);
        Console.WriteLine("\nЛототрон 60: ");
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"Выпало число: {lotto60.Draw()}");
        Console.WriteLine("Лототрон 100: ");
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"Выпало число: {lotto100.Draw()}");

        // Задание 5: Класс Employee
        Employee intern = new Employee("Стажер", 1, 50);
        Employee specialist = new Employee("Специалист", 5, 80);
        Employee manager = new Employee("Руководитель", 10, 100);
        intern.Work();
        specialist.Work();
        manager.Work();
    }
}
