namespace Meruert;

public class Weapon
{
    public double Damage { get; set; }
    public string Name { get; set; }

    public Weapon(string name, double damage)
    {
        Name = name;
        Damage = damage;
    }


}