public static class EnemyFactory{
    public static WareWolf SpawnWareWolf(int areaLevl){
        if(areaLevl < 5){
            return new WareWolf(100,12);
        }
        return new WareWolf(100,20);
    }

    public static Giant SpawnGiant(int areaLevl){
        if(areaLevl < 8){
            return new Giant(100,14);
        }
        return new Giant(100,32);
    }

    public static Zombie SpawnZombie(int areaLevl){
        if(areaLevl < 8){
            return new Zombie(66,5,7);
        }
        return new Zombie(100,32,20);
    }
}