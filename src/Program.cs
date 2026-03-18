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
    }
}
