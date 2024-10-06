public class PrimaryPalyer{

    public string Name { get; set; }
    private static PrimaryPalyer _instance;
    private PrimaryPalyer(){}

    public IWeapon weapon {get; set;}

    public static PrimaryPalyer GetInstance(){
        if(_instance is null){
            _instance = new PrimaryPalyer();
        }
        return _instance;
    }

    public int Health {get; set;}
    public int Armor {get; set;}
    public int FireDamage {get; set;}
}