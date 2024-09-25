public class Zombie : IEnemy
{
    public int Health { get; set; }
    public int Level { get; set; }

    public void Attack(PrimaryPalyer primaryPalyer)
    {
        System.Console.WriteLine("Zombie is attacking" + primaryPalyer.Name);
    }

    public void Defend(PrimaryPalyer primaryPalyer)
    {
        System.Console.WriteLine("Zombie is defending" + primaryPalyer.Name);
    }
}