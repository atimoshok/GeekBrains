package Java.Seminar4;

import Java.Seminar4.Weapons.Sword;

public class Swordman extends Warrior {

    public Swordman(String name, int healthPoint, Sword sword) {
        super(name, healthPoint, sword);
    }

    @Override
    public String toString() {
        return "Swordman, " + super.toString();
    }
    
}
