package OOP_Java.Seminar4.Weapons;
import OOP_Java.Seminar4.Weaponable;

public abstract class Weapon implements Weaponable {
    protected int pointOfDamage;

    public Weapon(int pointOfDamage) {
        this.pointOfDamage = pointOfDamage;
    }
}
