public interface IEnemy{
    int Health {get;set;}
    int Level {get; set;}
    void Attack(PrimaryPalyer primaryPalyer);
    void Defend(PrimaryPalyer primaryPalyer);
}