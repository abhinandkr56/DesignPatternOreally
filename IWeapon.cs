public interface IWeapon{
    int Damage {get; set;}
    void Use(IEnemy enemy);

}