using System.Linq.Expressions;

namespace Meruert;

public class Hero
{
    public string Name { get; set; }
    public double HP { get; set; }
    public double Mana { get; set; }

    public List<Weapon> Inventory { get; set; } = new List<Weapon>();

    public List<Armor> Armor { get; set; }

    public Hero()
    {
        string name = "";
        int hp = 0;

        while (name.Length < 1 || char.IsLower(name[0]))
        {
            Console.Write("Input name of your hero: ");
            name = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name can't be empty");

                }
                if (char.IsLower(name[0]))
                {
                    throw new Exception("Name needs first upper case letter");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Name = name;
        }

        while (hp < 100)
        {
            Console.Write("Input HP amount of your hero: ");
            int.TryParse(Console.ReadLine(), out hp);
            try
            {
                if (hp < 100)
                {
                    throw new ArgumentException("HP can't be lower then 100 and must be a number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            HP = hp;
        }
        Console.WriteLine();
        Console.WriteLine("End of hero setting up");
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

    public void Heals()
    { 
        Random rand = new Random();
        int giveHeals = rand.Next(10,30);
        HP += giveHeals;
        Console.WriteLine($"{Name} лечится, к здоровью прибалвяется {giveHeals}");
        Console.WriteLine($"У {Name} уровень здоровья: {HP}");
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