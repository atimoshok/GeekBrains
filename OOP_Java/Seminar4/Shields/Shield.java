// На основе работы на уроке.
// Создать класс щита, разработать разные типы щитов,
// добавить в семейство классов Warriors обобщения в виде щитов.
// Реструктуризировать код в конечных классах семейства Warriors.
// Добавить метод определения минимального щита в команде.
// * Продумать, как можно сделать воина без щита.

package OOP_Java.Seminar4.Shields;

import java.util.Random;

public class Shield implements Shieldable{
    protected int armor;

    public Shield(int armor) {
        this.armor = armor;
    }

    @Override
    public int blockDamage() {
        return new Random().nextInt(1, armor);
    }

    public int getArmor() {
        return armor;
    } 
}
