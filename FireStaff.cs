public class FireStaff : IWeapon
{
    public int Damage  {get; set;}
    public int FireDamage {get; set;}

    public FireStaff(int damage, int fireDamage){
        Damage = damage;
        FireDamage = fireDamage;
    }

    public void Use(IEnemy enemy)
    {
        enemy.Health -= Damage;
        enemy.OverTimeDamage -= FireDamage;
    }
}