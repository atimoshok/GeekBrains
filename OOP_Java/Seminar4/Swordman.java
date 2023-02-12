package OOP_Java.Seminar4;

import OOP_Java.Seminar4.Shields.*;
import OOP_Java.Seminar4.Weapons.Sword;

public class Swordman extends Warrior {
    private Shieldable shield;

    public Swordman(String name, int healthPoint, Sword sword, Shieldable shield) {
        super(name, healthPoint, sword);
        this.shield = shield;
    }

    public Swordman(String name, int healthPoint, Sword sword) {
        super(name, healthPoint, sword);
        this.shield = null;
    }

    @Override
    public String toString() {
        return "Swordman, " + super.toString();
    }

    public int armorAmount() {
        return ((Shield) getWeapon()).getArmor();
    }
    
}
