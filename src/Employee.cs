// Класс Employee (Сотрудник)
public class Employee
{
    public int SkillLevel { get; set; }
    public int Energy { get; set; }
    public string Name { get; set; }

    public Employee(string name, int skillLevel, int energy)
    {
        Name = name;
        SkillLevel = skillLevel;
        Energy = energy;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} выполняет задачу. Навык: {SkillLevel}, Энергия: {Energy}");
    }
}
