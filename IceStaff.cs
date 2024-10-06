public class IceStaff : IWeapon
{
    public int Damage  {get; set;}
    public int ParalysedFor {get; set;}

    public IceStaff(int damage, int paralysedFor){
        Damage = damage;
        ParalysedFor = paralysedFor;
    }
    public void Use(IEnemy enemy)
    {
        enemy.Health -= Damage;
        enemy.Paralysed = true;
    }
}