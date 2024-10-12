public class WeaponAdapter : IWeapon
{
    ISpaceWeapon _spaceWeapon;
    int IWeapon.Damage { get => _spaceWeapon.LaserDamage + _spaceWeapon.LaserDamage; set => throw new NotImplementedException(); }

    public void Use(IEnemy enemy)
    {
        enemy.Health -= _spaceWeapon.Shoot();
    }
}