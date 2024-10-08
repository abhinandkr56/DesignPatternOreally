public class Zombie : IEnemy
{
    public int Health { get; set; }
    public int Level { get; set; }
    public int OverTimeDamage { get; set; }
    public int Armor { get; set; }
    public bool Paralysed { get; set; }
    public int ParalysedFor { get; set; }

    public Zombie(int health, int level, int armor){
        Health = health;
        Level = level;
        Armor = armor;
    }

    public void Attack(PrimaryPalyer primaryPalyer)
    {
        System.Console.WriteLine("Zombie is attacking" + primaryPalyer.Name);
    }

    public void Defend(PrimaryPalyer primaryPalyer)
    {
        System.Console.WriteLine("Zombie is defending" + primaryPalyer.Name);
    }
}