namespace Meruert;

public class Hero
{
    public string Name { get; set; }
    public double HP { get; set; }
    public double Mana { get; set; }

    public List<Weapon> Inventory { get; set; } = new List<Weapon>();

    public List<Armor> Armor { get; set; }

    public Hero(string name, double hp)
    {
        Name = name;
        HP = hp;
    }

    public double Bite(Dragon dragon)
    {
        Console.WriteLine($"{Name} bites {dragon.Name}...");
        Random rand = new Random();
        double damage = rand.Next(1,5);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{dragon.Name} has taken {damage} damage, ouch!");
        return damage;
    }

    public double TakeDamage(double damage)
    {
        HP -= damage;
        Console.WriteLine($"{Name} has taken {damage} damage, ouch!");
        if (damage >= HP)
        {
            Console.WriteLine($"{Name} fucking dies, because he is a stupid bum!");
        }
        else
        { 
            Console.WriteLine($"{Name}'s hp - {HP}");
        }
        return HP;
    }

    public void AddInInventory(Weapon weapon)
    {
        Inventory.Add(weapon);
        foreach (var inventary in Inventory)
        {
            Console.WriteLine($"У героя {Name} появился {inventary.Name} с уроном {inventary.Damage}");
        }
    }
}