using System.Security.Cryptography.X509Certificates;

public class GameBoard{

    private PrimaryPalyer _primaryPalyer;
    public GameBoard()
    {
        _primaryPalyer = PrimaryPalyer.GetInstance();
    }

    public void PlayArea(int level){
        if(level == 1){
            PlayFirst();
        }
    }

    public void PlayFirst(){
        List<IEnemy> enemies = new List<IEnemy>();

        for(int i = 0; i< 10; i++){
            enemies.Add(EnemyFactory.SpawnGiant(1));
        }
         for(int i = 0; i< 10; i++){
            enemies.Add(EnemyFactory.SpawnWareWolf(1));
        }
         for(int i = 0; i< 10; i++){
            enemies.Add(EnemyFactory.SpawnZombie(1));
        }

        foreach(var item in enemies){
            while(item.Health > 0 || _primaryPalyer.Health > 0){
                _primaryPalyer.weapon.Use(item);
                item.Attack(_primaryPalyer);
            }
        }
    }
}