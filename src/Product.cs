// Класс Product (Товар)
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsInStock { get; set; }

    // Конструктор по умолчанию
    public Product()
    {
        Name = "Неизвестно";
        Price = 0;
        IsInStock = false;
    }

    // Конструктор с параметрами
    public Product(string name, decimal price, bool isInStock)
    {
        Name = name;
        Price = price;
        IsInStock = isInStock;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Товар: {Name}, Цена: {Price} руб., В наличии: {(IsInStock ? "Да" : "Нет")}");
    }
}
