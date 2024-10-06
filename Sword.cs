public class Sword : IWeapon
{
    public int Damage {get; set;}
    public int ArmorDamage {get; set;}

    public Sword(int damage, int armorDamage){
        Damage = damage;
        ArmorDamage = armorDamage;
    }
    public void Use(IEnemy enemy)
    {
        enemy.Health -= Damage;
        enemy.Armor -=ArmorDamage;
    }
}