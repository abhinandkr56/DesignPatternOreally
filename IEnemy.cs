public interface IEnemy{
    int Health {get;set;}
    int Level {get; set;}
    int OverTimeDamage {get; set;}
    int Armor {get; set;}
    bool Paralysed {get; set;}
    int ParalysedFor {get; set;}
    void Attack(PrimaryPalyer primaryPalyer);
    void Defend(PrimaryPalyer primaryPalyer);
}