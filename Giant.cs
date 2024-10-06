public class Giant : IEnemy{
     public int Health { get; set; }
    public int Level { get; set; }
    public int OverTimeDamage { get; set; }
    public int Armor { get; set; }
    public bool Paralysed { get; set; }
    public int ParalysedFor { get; set; }

    public Giant(int health, int level){
        Health = health;
        Level = level;
    }
    public void Attack(PrimaryPalyer primaryPalyer)
    {
        System.Console.WriteLine("Giant is attacking" + primaryPalyer.Name);
    }

    public void Defend(PrimaryPalyer primaryPalyer)
    {
        System.Console.WriteLine("Giant is defending" + primaryPalyer.Name);
    }
}