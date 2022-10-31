namespace Meruert;

public class Dragon
{
    private string _name;
    public double HP { get; set; }
    public double Damage { get; set; }
    public double Mana { get; set; }
    public double Armor { get; set; }
    public string Name {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
            if (_name == "Smaug")
            {
                Console.WriteLine($"Hello {_name}");
            }
        }
            }


    public Dragon(string name, double hp) { 
        Name = name;
        HP = hp;    
    }

    public double TakeDamage(double damage)
    {
        if (damage >= HP)
        {
            Console.WriteLine("${Name} dies, ugh!");
        }
        else {
            HP -= damage;
            Console.WriteLine($"{Name}'s hp - {HP}");
        }
        return HP;
    }

    public double Incinerate(Hero gero) {
        Console.WriteLine($"{Name} breathes fire...");
        Random random = new Random();
        double damage = random.Next(100, 300);
        return damage;
    }

}