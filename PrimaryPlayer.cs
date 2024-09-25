public class PrimaryPalyer{

    public string Name { get; set; }
    private static PrimaryPalyer _instance;
    private PrimaryPalyer(){}

    public static PrimaryPalyer GetInstance(){
        if(_instance is null){
            _instance = new PrimaryPalyer();
        }
        return _instance;
    }
}